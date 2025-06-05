import os.path
import sys

from data import Data

def GetLocation(location_list, item_id):
    for location in location_list:
        if location.item_id == item_id:
            return location


if __name__ == '__main__':
    if not os.path.exists('s3.gba'):
        print('Rom (s3.gba) missing')
        sys.exit(0)
    if not os.path.exists('settings.csv'):
        print('Settings (settings.csv) missing')
        sys.exit(0)
    rom_file = open('s3.gba', mode='rb')
    rom_byte = bytearray(rom_file.read())

    settings_file = open('settings.csv', mode='r')
    settings_text = settings_file.read()

    swap_list = Data.SwapList(None, settings_text)
    location_list = Data.PopulateLocations(None)

    quest_item_address = 0x1C009C

    for swap in swap_list:
        location = GetLocation(location_list, swap.item_from_id)
        rom_byte[location.address] = swap.item_to_id

        match location.item_type:
            # Free Standing
            case 0x1:
                rom_byte[quest_item_address + ((swap.item_to_id - 0x43) * 8) + 2] = 0x1
            # Red
            case 0x2:
                rom_byte[quest_item_address + ((swap.item_to_id - 0x43) * 8) + 2] = 0x1
            # Green
            case 0x3:
                rom_byte[quest_item_address + ((swap.item_to_id - 0x43) * 8) + 2] = 0x1
            # Purple
            case 0x4:
                rom_byte[quest_item_address + ((swap.item_to_id - 0x43) * 8) + 2] = 0x1
            # Yellow
            case 0x5:
                rom_byte[quest_item_address + ((swap.item_to_id - 0x43) * 8) + 2] = 0x1
            # NPC
            case 0x0:
                rom_byte[quest_item_address + ((swap.item_to_id - 0x43) * 8) + 2] = 0x0
            # case 0x6:
            # case 0x7:

        print('Was: ' + str(swap.item_from_id) + ' Now: ' + str(swap.item_to_id))

    with open('mod.gba', mode='wb') as f:
        f.write(rom_byte)

    print('Done!')
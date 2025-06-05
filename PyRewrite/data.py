class ItemSwap:
    def __init__(self, item_from_id, item_to_id):
        self.item_from_id = item_from_id
        self.item_to_id = item_to_id


class Location:
    def __init__(self, item_id, item_type, address):
        self.item_id = item_id
        self.item_type = item_type
        self.address = address

class Data():
    def SwapList(self, settings_text):
        swaps = []

        settings_lines = settings_text.split('\n')

        for line in settings_lines:
            if len(line) > 0:
                item_from = line.split(',')[0]
                item_to = line.split(',')[1]
                swaps.append(ItemSwap(int(item_from, 16), int(item_to, 16)))

        return swaps
    def PopulateLocations(self):
        location_list = []

        location_list.append(Location(0x43, 0x1, 0x0025BED5))
        location_list.append(Location(0x44, 0x3, 0x002696F4))
        location_list.append(Location(0x45, 0x0, 0x00636EEC))
        location_list.append(Location(0x46, 0x0, 0x00637A77))
        location_list.append(Location(0x48, 0x0, 0x0063868D))
        location_list.append(Location(0x49, 0x6, 0x006372FF))
        location_list.append(Location(0x4A, 0x0, 0x0063895F))
        location_list.append(Location(0x4B, 0x3, 0x00275C13))
        location_list.append(Location(0x4C, 0x4, 0x00275D7B))
        location_list.append(Location(0x4D, 0x0, 0x00637646))
        location_list.append(Location(0x4E, 0x0, 0x0063770E))
        location_list.append(Location(0x4F, 0x0, 0x006375A7))
        location_list.append(Location(0x50, 0x1, 0x002A918E))
        location_list.append(Location(0x52, 0x2, 0x00275E3A))
        location_list.append(Location(0x53, 0x1, 0x00226959))
        location_list.append(Location(0x54, 0x0, 0x00638B83))
        location_list.append(Location(0x55, 0x1, 0x00226A6A))
        location_list.append(Location(0x56, 0x0, 0x00638B31))
        location_list.append(Location(0x57, 0x1, 0x002AF652))
        location_list.append(Location(0x58, 0x1, 0x002FEF12))
        location_list.append(Location(0x59, 0x2, 0x00226A72))
        location_list.append(Location(0x5A, 0x4, 0x00226A7A))
        location_list.append(Location(0x5B, 0x1, 0x002E6FDD))
        location_list.append(Location(0x5C, 0x0, 0x00637E6C))
        location_list.append(Location(0x5D, 0x0, 0x00637DC7))
        location_list.append(Location(0x5E, 0x0, 0x00637F4E))
        location_list.append(Location(0x5F, 0x1, 0x002ADEBD))
        location_list.append(Location(0x60, 0x0, 0x00637E12))
        location_list.append(Location(0x61, 0x6, 0x00637225))
        location_list.append(Location(0x62, 0x2, 0x002E711D))
        location_list.append(Location(0x63, 0x4, 0x002F6A24))
        location_list.append(Location(0x64, 0x0, 0x006388C3))
        location_list.append(Location(0x65, 0x0, 0x00637819))
        location_list.append(Location(0x66, 0x0, 0x0063856F))
        location_list.append(Location(0x67, 0x1, 0x002AE874))
        location_list.append(Location(0x68, 0x0, 0x00638596))
        location_list.append(Location(0x69, 0x7, 0x00637105))
        location_list.append(Location(0x6A, 0x0, 0x0063795F))
        location_list.append(Location(0x6B, 0x4, 0x002CB923))
        location_list.append(Location(0x6C, 0x0, 0x00638A2D))
        location_list.append(Location(0x6D, 0x0, 0x00636C0A))
        location_list.append(Location(0x6E, 0x1, 0x002AD17E))
        location_list.append(Location(0x6F, 0x0, 0x00637B93))
        location_list.append(Location(0x70, 0x2, 0x002CB914))
        location_list.append(Location(0x71, 0x2, 0x002CB91B))
        location_list.append(Location(0x72, 0x5, 0x002CB92B))
        location_list.append(Location(0x73, 0x3, 0x0021D819))
        location_list.append(Location(0x74, 0x1, 0x0021D58C))
        location_list.append(Location(0x75, 0x0, 0x00637C81))
        location_list.append(Location(0x76, 0x0, 0x00637D30))
        location_list.append(Location(0x77, 0x0, 0x00637B1A))
        location_list.append(Location(0x78, 0x1, 0x002A6162))
        location_list.append(Location(0x79, 0x2, 0x0021D4D0))
        location_list.append(Location(0x7A, 0x7, 0x00637195))
        location_list.append(Location(0x7B, 0x3, 0x00284126))
        location_list.append(Location(0x7C, 0x1, 0x0028A029))
        location_list.append(Location(0x7D, 0x0, 0x0063746A))
        location_list.append(Location(0x7E, 0x0, 0x00637514))
        location_list.append(Location(0x7F, 0x0, 0x00637406))
        location_list.append(Location(0x81, 0x1, 0x002A9BF2))
        location_list.append(Location(0x82, 0x2, 0x0028A345))
        location_list.append(Location(0x83, 0x1, 0x002B69B2))
        location_list.append(Location(0x84, 0x4, 0x002B6BD3))
        location_list.append(Location(0x86, 0x0, 0x006379AF))
        location_list.append(Location(0x87, 0x0, 0x006377BE))
        location_list.append(Location(0x88, 0x1, 0x002AA849))
        location_list.append(Location(0x89, 0x3, 0x002B6AFE))
        location_list.append(Location(0x8A, 0x7, 0x0063714D))
        location_list.append(Location(0x8B, 0x3, 0x00250D9E))
        location_list.append(Location(0x8C, 0x1, 0x00250B03))
        location_list.append(Location(0x8D, 0x0, 0x00636CD3))
        location_list.append(Location(0x8E, 0x0, 0x00637388))
        location_list.append(Location(0x8F, 0x0, 0x00636C8B))
        location_list.append(Location(0x90, 0x0, 0x00636D46))
        location_list.append(Location(0x91, 0x7, 0x006371DD))
        location_list.append(Location(0x92, 0x0, 0x00637AC7))
        location_list.append(Location(0x93, 0x3, 0x0029D9C3))
        location_list.append(Location(0x94, 0x0, 0x00638810))
        location_list.append(Location(0x95, 0x4, 0x0029D9CB))
        location_list.append(Location(0x96, 0x4, 0x00294328))
        location_list.append(Location(0x97, 0x5, 0x0029D9FA))
        location_list.append(Location(0x98, 0x1, 0x002ABB5E))
        location_list.append(Location(0x99, 0x2, 0x00294330))
        location_list.append(Location(0x9A, 0x2, 0x00294320))
        location_list.append(Location(0x9B, 0x4, 0x002DEBAE))
        location_list.append(Location(0x9C, 0x0, 0x0063891C))
        location_list.append(Location(0x9D, 0x0, 0x00637CA3))
        location_list.append(Location(0x9E, 0x6, 0x006372B5))
        location_list.append(Location(0x9F, 0x5, 0x002DEBB5))
        location_list.append(Location(0xA0, 0x5, 0x002DEC4D))
        location_list.append(Location(0xA1, 0x1, 0x002A70D5))
        location_list.append(Location(0xA2, 0x6, 0x0063726D))
        location_list.append(Location(0xA6, 0x5, 0x0023FD68))
        return location_list
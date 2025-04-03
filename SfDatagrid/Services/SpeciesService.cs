using SfDatagrid.Models;
using System.Collections.Generic;

namespace SfDatagrid.Services;

// This static service holds our hardcoded species list (eventually could load from an API or file)
public static class SpeciesDataService
{
    public static List<Species> GetSpecies() => new()
    {
        new() { Order = "Coleoptera", ScientificName = "Tribolium confusum", CommonName = "Confused Flour Beetle", Abbreviation = "CFB", EPPOCode = "TRIBCO", SortOrder = 1 },
        new() { Order = "Coleoptera", ScientificName = "Tribolium castaneum", CommonName = "Red Flour Beetle", Abbreviation = "RFB", EPPOCode = "TRIBCA", SortOrder = 2 },
        new() { Order = "Coleoptera", ScientificName = "Oryzaephilus surinamensis", CommonName = "Sawtoothed Grain Beetle", Abbreviation = "STGB", EPPOCode = "ORYZSU", SortOrder = 3 },
        new() { Order = "Coleoptera", ScientificName = "Trogoderma variabile", CommonName = "Warehouse Beetle", Abbreviation = "WHB", EPPOCode = "TROGPA", SortOrder = 4 },
        new() { Order = "Lepitoptera", ScientificName = "Plodia interpunctella", CommonName = "Indian Meal Moth", Abbreviation = "IMM", EPPOCode = "PLODIN", SortOrder = 5 },
        new() { Order = "Lepitoptera", ScientificName = "Ephestia kuehniella", CommonName = "Mediterranean Flour Moth", Abbreviation = "MFM", EPPOCode = "EPHEKU", SortOrder = 6 },
        new() { Order = "Lepitoptera", ScientificName = "Amyelois transitella", CommonName = "Navel Orangeworm", Abbreviation = "NOW", EPPOCode = "PARMTR", SortOrder = 7 },
        new() { Order = "Coleoptera", ScientificName = "Sitophilus granarius", CommonName = "Granary Weevil", Abbreviation = "GW", EPPOCode = "CALAGR", SortOrder = 8 },
        new() { Order = "Coleoptera", ScientificName = "Sitophilus oryzae", CommonName = "Rice Weevil", Abbreviation = "RW", EPPOCode = "CALAOR", SortOrder = 9 },
        new() { Order = "Coleoptera", ScientificName = "Rhyzopertha dominica", CommonName = "Lesser Grain Borer", Abbreviation = "LGB", EPPOCode = "RHITDO", SortOrder = 10 },
        new() { Order = "Coleoptera", ScientificName = "Dermestes maculatus", CommonName = "Hide Beetle", Abbreviation = "HB", EPPOCode = "DERMMA", SortOrder = 11 },
        new() { Order = "Coleoptera", ScientificName = "Stegobium paniceum", CommonName = "Drugstore Beetle", Abbreviation = "DSB", EPPOCode = "STEGPA", SortOrder = 12 },
        new() { Order = "Coleoptera", ScientificName = "Cryptolestes ferrugineus", CommonName = "Rust Red Grain Beetle", Abbreviation = "RRGB", EPPOCode = "CRYLFE", SortOrder = 13 },
        new() { Order = "Lepitoptera", ScientificName = "Ephestia cautella", CommonName = "Almond Moth", Abbreviation = "AM", EPPOCode = "EPHECA", SortOrder = 14 },
        new() { Order = "Coleoptera", ScientificName = "Lasioderma serricorne", CommonName = "Cigarette Beetle", Abbreviation = "CB", EPPOCode = "LASDSE", SortOrder = 15 },
        new() { Order = "Coleoptera", ScientificName = "Callosobruchus maculatus", CommonName = "Cowpea Weevil", Abbreviation = "CPW", EPPOCode = "CALSMA", SortOrder = 16 },
        new() { Order = "Coleoptera", ScientificName = "Acanthoscelides obtectus", CommonName = "Bean Weevil", Abbreviation = "BW", EPPOCode = "ACANOB", SortOrder = 17 },
        new() { Order = "Lepitoptera", ScientificName = "Ephestia elutella", CommonName = "Cocoa Moth", Abbreviation = "CM", EPPOCode = "EPHEEL", SortOrder = 18 },
        new() { Order = "Coleoptera", ScientificName = "Carpophilus hemipterus", CommonName = "Dried Fruit Beetle", Abbreviation = "DFB", EPPOCode = "CARHHE", SortOrder = 19 },
        new() { Order = "Coleoptera", ScientificName = "Ahasverus advena", CommonName = "Foreign Grain Beetle", Abbreviation = "FGB", EPPOCode = "AHASAD", SortOrder = 20 },
    };
}

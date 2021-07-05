namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCountries : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Countries (CountryName, Flag, Capital, Population) VALUES " +
                "('Austria', 'images\\austria.png', 'Vienna', 8822267), " +
                "('Belgium', 'images\\belgium.png', 'Brussels', 11420163), " +
                "('Bulgaria', 'images\\bulgaria.png', 'Sofia', 7000039), " +
                "('Cyprus', 'images\\cyprus.png', 'Nicosia', 1170125), " +
                "('Czech Republic', 'images\\czech.png', 'Prague', 10649800), " +
                "('Denmark', 'images\\denmark.png', 'Copenhagen', 5814461), " +
                "('Estonia', 'images\\estonia.png', 'Tallinn', 1319133), " +
                "('Finland', 'images\\finland.png', 'Helsinki', 5513130), " +
                "('France', 'images\\france.png', 'Paris', 66992000), " +
                "('Germany', 'images\\germany.png', 'Berlin', 82850000), " +
                "('Greece', 'images\\greece.png', 'Athens', 10738868), " +
                "('Hungary', 'images\\hungary.png', 'Budapest', 9778371), " +
                "('Ireland', 'images\\ireland.png', 'Dublin', 4838259), " +
                "('Italy', 'images\\italy.png', 'Rome', 60483973), " +
                "('Latvia', 'images\\latvia.png', 'Riga', 1934379), " +
                "('Lithuania', 'images\\lithuania.png', 'Vilnius', 2808901), " +
                "('Luxembourg', 'images\\luxembourg.png', 'Luxembourg City', 602005), " +
                "('Malta', 'images\\malta.png', 'Valletta', 475701), " +
                "('Netherlands', 'images\\netherlands.png', 'Amsterdam', 17118084), " +
                "('Poland', 'images\\poland.png', 'Warsaw', 37976687)," +
                "('Portugal', 'images\\portugal.png', 'Lisbon', 10291027), " +
                "('Romania', 'images\\romania.png', 'Bucharest', 19523621), " +
                "('Slovakia', 'images\\slovakia.png', 'Bratislava', 5443120), " +
                "('Slovenia', 'images\\slovenia.png', 'Ljubljana', 2066880), " +
                "('Spain', 'images\\spain.png', 'Madrid', 46659302), " +
                "('Sweden', 'images\\sweden.png', 'Stockholm', 10120242), " +
                "('United Kingdom', 'images\\uk.png', 'London', 66238007)");
        }
        
        public override void Down()
        {
        }
    }
}

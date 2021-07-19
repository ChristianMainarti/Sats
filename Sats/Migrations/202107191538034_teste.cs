namespace Sats.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfigBomba",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Estado = c.Boolean(nullable: false),
                        Ponto_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pontos", t => t.Ponto_ID, cascadeDelete: true)
                .Index(t => t.Ponto_ID);
            
            CreateTable(
                "dbo.Pontos",
                c => new
                    {
                        ID_Ponto = c.Int(nullable: false, identity: true),
                        Nome_Ponto = c.String(maxLength: 50, storeType: "nvarchar"),
                        Endereço_Ponto = c.String(maxLength: 100, storeType: "nvarchar"),
                        Nome_Medidor = c.String(maxLength: 50, storeType: "nvarchar"),
                        Tipo_Medidor = c.String(maxLength: 50, storeType: "nvarchar"),
                        Macro_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Ponto)
                .ForeignKey("dbo.Macros", t => t.Macro_ID, cascadeDelete: true)
                .Index(t => t.Macro_ID);
            
            CreateTable(
                "dbo.ConfigNv",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LimSup = c.Int(nullable: false),
                        LimInf = c.Int(nullable: false),
                        Ponto_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pontos", t => t.Ponto_ID, cascadeDelete: true)
                .Index(t => t.Ponto_ID);
            
            CreateTable(
                "dbo.ConfigVaz",
                c => new
                    {
                        ID_ConfigV = c.Int(nullable: false, identity: true),
                        Unidade_Medida = c.Int(nullable: false),
                        Ponto_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ConfigV)
                .ForeignKey("dbo.Pontos", t => t.Ponto_ID, cascadeDelete: true)
                .Index(t => t.Ponto_ID);
            
            CreateTable(
                "dbo.LeiturasBomba",
                c => new
                    {
                        ID_Leitura = c.Int(nullable: false, identity: true),
                        Data_Hora = c.DateTime(nullable: false, precision: 0),
                        Leiturista = c.String(maxLength: 50, storeType: "nvarchar"),
                        Valor_Leitura = c.Boolean(nullable: false),
                        Ponto_Leitura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Leitura)
                .ForeignKey("dbo.Pontos", t => t.Ponto_Leitura, cascadeDelete: true)
                .Index(t => t.Ponto_Leitura);
            
            CreateTable(
                "dbo.LeiturasNível",
                c => new
                    {
                        ID_Leitura = c.Int(nullable: false, identity: true),
                        Data_Hora = c.DateTime(nullable: false, precision: 0),
                        Leiturista = c.String(maxLength: 50, storeType: "nvarchar"),
                        Valor_Leitura = c.Single(nullable: false),
                        Tipo_Nível = c.Boolean(nullable: false),
                        Ponto_Leitura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Leitura)
                .ForeignKey("dbo.Pontos", t => t.Ponto_Leitura, cascadeDelete: true)
                .Index(t => t.Ponto_Leitura);
            
            CreateTable(
                "dbo.LeiturasVazão",
                c => new
                    {
                        ID_Leitura = c.Int(nullable: false, identity: true),
                        Data_Hora = c.DateTime(nullable: false, precision: 0),
                        Leiturista = c.String(maxLength: 50, storeType: "nvarchar"),
                        Valor_Leitura = c.Single(nullable: false),
                        Ponto_Leitura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Leitura)
                .ForeignKey("dbo.Pontos", t => t.Ponto_Leitura, cascadeDelete: true)
                .Index(t => t.Ponto_Leitura);
            
            CreateTable(
                "dbo.Macros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome_Macro = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Leituras",
                c => new
                    {
                        Leiturista = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Data_Hora = c.DateTime(nullable: false, precision: 0),
                        Valor_Leitura = c.Single(nullable: false),
                        Ponto_Leitura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Leiturista);
            
            CreateTable(
                "dbo.Tipos_Ponto",
                c => new
                    {
                        ID_Nome = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID_Nome);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConfigBomba", "Ponto_ID", "dbo.Pontos");
            DropForeignKey("dbo.Pontos", "Macro_ID", "dbo.Macros");
            DropForeignKey("dbo.LeiturasVazão", "Ponto_Leitura", "dbo.Pontos");
            DropForeignKey("dbo.LeiturasNível", "Ponto_Leitura", "dbo.Pontos");
            DropForeignKey("dbo.LeiturasBomba", "Ponto_Leitura", "dbo.Pontos");
            DropForeignKey("dbo.ConfigVaz", "Ponto_ID", "dbo.Pontos");
            DropForeignKey("dbo.ConfigNv", "Ponto_ID", "dbo.Pontos");
            DropIndex("dbo.LeiturasVazão", new[] { "Ponto_Leitura" });
            DropIndex("dbo.LeiturasNível", new[] { "Ponto_Leitura" });
            DropIndex("dbo.LeiturasBomba", new[] { "Ponto_Leitura" });
            DropIndex("dbo.ConfigVaz", new[] { "Ponto_ID" });
            DropIndex("dbo.ConfigNv", new[] { "Ponto_ID" });
            DropIndex("dbo.Pontos", new[] { "Macro_ID" });
            DropIndex("dbo.ConfigBomba", new[] { "Ponto_ID" });
            DropTable("dbo.Tipos_Ponto");
            DropTable("dbo.Leituras");
            DropTable("dbo.Macros");
            DropTable("dbo.LeiturasVazão");
            DropTable("dbo.LeiturasNível");
            DropTable("dbo.LeiturasBomba");
            DropTable("dbo.ConfigVaz");
            DropTable("dbo.ConfigNv");
            DropTable("dbo.Pontos");
            DropTable("dbo.ConfigBomba");
        }
    }
}

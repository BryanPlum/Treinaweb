namespace Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {

        // Classe gerada com o código 
        //Add-Migration MigracaoInicial -ProjectName Musicas.AcessoDados.Entity -StartUpProjectName Musicas.AcessoDados.Entity
        //no terminal
        //Depois, rodar o comando 
        //Update-Database -ProjectName Musicas.AcessoDados.Entity -StartUpProjectName Musicas.AcessoDados.Entity -Verbose
        //para atualizar o banco de dados
        public override void Up()
        {
            CreateTable(
                "dbo.ALB_ALBUMS",
                c => new
                    {
                        ALB_ID = c.Int(nullable: false, identity: true),
                        ALB_NOME = c.String(nullable: false, maxLength: 100),
                        ALB_ANO = c.Int(nullable: false),
                        ALB_OBSERVACOES = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ALB_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ALB_ALBUMS");
        }
    }
}

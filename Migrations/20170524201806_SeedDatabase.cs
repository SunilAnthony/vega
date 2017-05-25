using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) Values('Make1')"); 
            migrationBuilder.Sql("INSERT INTO Makes (Name) Values('Make2')"); 
            migrationBuilder.Sql("INSERT INTO Makes (Name) Values('Make3')"); 

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelA', (Select Id FROM Makes Where Name = 'Make1'))"); 
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelB', (Select Id FROM Makes Where Name = 'Make1'))"); 
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelC', (Select Id FROM Makes Where Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelA', (Select Id FROM Makes Where Name = 'Make2'))"); 
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelB', (Select Id FROM Makes Where Name = 'Make2'))"); 
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelC', (Select Id FROM Makes Where Name = 'Make2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelA', (Select Id FROM Makes Where Name = 'Make3'))"); 
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelB', (Select Id FROM Makes Where Name = 'Make3'))"); 
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) Values ('Make1-ModelC', (Select Id FROM Makes Where Name = 'Make3'))"); 
           
                       
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Makes Where Name in ('Make1','Make2','Make3')");
           
        }
    }
}

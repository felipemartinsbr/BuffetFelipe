using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Buffet.Migrations
{
    public partial class NovasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataEventoInserido",
                table: "Eventos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEventoModificado",
                table: "Eventos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Eventos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Eventos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Eventos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "Eventos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Eventos",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SituacaoId",
                table: "Eventos",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TipoDeEventoId",
                table: "Eventos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cnpj",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Clientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EntradaCliente",
                table: "Clientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Observaçoes",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TipoClienteId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaModificacaoCliente",
                table: "Clientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SituacaoEventoEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Agendado = table.Column<bool>(nullable: false),
                    Cancelado = table.Column<bool>(nullable: false),
                    Executado = table.Column<bool>(nullable: false),
                    OutrasSituacoes = table.Column<bool>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoEventoEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoClienteEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    PessoaFisica = table.Column<bool>(nullable: false),
                    PessoaJuridica = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoClienteEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEventoEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEventoEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_SituacaoId",
                table: "Eventos",
                column: "SituacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_TipoDeEventoId",
                table: "Eventos",
                column: "TipoDeEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoClienteId",
                table: "Clientes",
                column: "TipoClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TipoClienteEntity_TipoClienteId",
                table: "Clientes",
                column: "TipoClienteId",
                principalTable: "TipoClienteEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_SituacaoEventoEntity_SituacaoId",
                table: "Eventos",
                column: "SituacaoId",
                principalTable: "SituacaoEventoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_TipoEventoEntity_TipoDeEventoId",
                table: "Eventos",
                column: "TipoDeEventoId",
                principalTable: "TipoEventoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TipoClienteEntity_TipoClienteId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_SituacaoEventoEntity_SituacaoId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TipoEventoEntity_TipoDeEventoId",
                table: "Eventos");

            migrationBuilder.DropTable(
                name: "SituacaoEventoEntity");

            migrationBuilder.DropTable(
                name: "TipoClienteEntity");

            migrationBuilder.DropTable(
                name: "TipoEventoEntity");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_SituacaoId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_TipoDeEventoId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TipoClienteId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataEventoInserido",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "DataEventoModificado",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Local",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "SituacaoId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "TipoDeEventoId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Cnpj",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EntradaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Observaçoes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoClienteId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "UltimaModificacaoCliente",
                table: "Clientes");
        }
    }
}

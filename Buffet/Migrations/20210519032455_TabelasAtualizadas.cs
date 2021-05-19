using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Buffet.Migrations
{
    public partial class TabelasAtualizadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PessoaFisica",
                table: "TipoClienteEntity");

            migrationBuilder.DropColumn(
                name: "PessoaJuridica",
                table: "TipoClienteEntity");

            migrationBuilder.DropColumn(
                name: "Agendado",
                table: "SituacaoEventoEntity");

            migrationBuilder.DropColumn(
                name: "Cancelado",
                table: "SituacaoEventoEntity");

            migrationBuilder.DropColumn(
                name: "Executado",
                table: "SituacaoEventoEntity");

            migrationBuilder.DropColumn(
                name: "OutrasSituacoes",
                table: "SituacaoEventoEntity");

            migrationBuilder.CreateTable(
                name: "SituacaoConvidadoEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoConvidadoEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Convidados",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    EventoId = table.Column<Guid>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: true),
                    Observacoes = table.Column<string>(nullable: true),
                    DataConvidadoInserido = table.Column<DateTime>(nullable: false),
                    DataConvidadoModificado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convidados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Convidados_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Convidados_SituacaoConvidadoEntity_TypeId",
                        column: x => x.TypeId,
                        principalTable: "SituacaoConvidadoEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Convidados_EventoId",
                table: "Convidados",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Convidados_TypeId",
                table: "Convidados",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Convidados");

            migrationBuilder.DropTable(
                name: "SituacaoConvidadoEntity");

            migrationBuilder.AddColumn<bool>(
                name: "PessoaFisica",
                table: "TipoClienteEntity",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PessoaJuridica",
                table: "TipoClienteEntity",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Agendado",
                table: "SituacaoEventoEntity",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cancelado",
                table: "SituacaoEventoEntity",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Executado",
                table: "SituacaoEventoEntity",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OutrasSituacoes",
                table: "SituacaoEventoEntity",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}

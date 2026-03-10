using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Companion;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Services
{
    public class RelatorioSituacaoAtendimentos
    {
        public string GerarListaSituacaoAtendimentos(List<SituacaoAtendimentos> listaAtendimentos)
        {
            QuestPDF.Settings.License =
                QuestPDF.Infrastructure.LicenseType.Community;

            string caminho = Path.Combine(Path.GetTempPath(),
                $"RelatorioSituacaoAtendimentos_{Guid.NewGuid()}.pdf");

            Document.Create(contador =>
            {

                contador.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Verdana));
                    
                    //Ínicio do cabeçalho
                    page.Header().BorderBottom(1).PaddingBottom(5).Row(row =>
                    {
                        row.RelativeItem(1).Column(col =>
                        {
                            string logoPath = Path.Combine(AppContext.BaseDirectory, "Assets", "logotiposenac.png");
                            if (File.Exists(logoPath))
                            {
                                col.Item().Width(80).Image(logoPath);
                            }
                            else
                            {
                                col.Item().Text("SENAC").FontSize(14).Bold();
                            }
                        });
                        row.RelativeItem(1).AlignCenter().AlignMiddle().Text("Relatório de Situação dos Atendimentos").FontSize(14).Bold();
                        row.RelativeItem(1).AlignRight().AlignMiddle().Text(t =>
                        {
                            t.Span("Data: ").Bold();
                            t.Span(DateTime.Now.ToString("dd/MM/yyyy"));
                        });
                    });

                    //Conteúdo Central
                    page.Content().PaddingVertical(10).Table(table => {
                    
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.RelativeColumn(4);
                            columns.RelativeColumn(6);
                        });
                        //Cabeçalho da tabela
                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("ID").FontSize(10).Bold();
                            header.Cell().Element(CellStyle).Text("Estatus").FontSize(10).Bold();
                            header.Cell().Element(CellStyle).Text("Ativo").FontSize(10).Bold();
                        });
                        //Dados da tabela
                        foreach (var atendimento in listaAtendimentos)
                        {
                            table.Cell().Element(CellStyle).Text(atendimento.Id.ToString());
                            table.Cell().Element(CellStyle).Text(atendimento.Nome ?? "-");
                            table.Cell().Element(CellStyle).Text(atendimento.Ativo ? "Sim" : "Não");
                        }
                        //Estilo das células
                        IContainer CellStyle(IContainer container)
                        {
                            return container.BorderBottom(1).PaddingVertical(5);
                        }

                    });
                    
                    //Rodapé
                    page.Footer().AlignCenter().Text(t =>
                    {
                        t.Span("Gerado por Sistema de Atendimento - ").Bold();
                        t.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    });
                });
            }).GeneratePdf(caminho);

            return caminho;
        }
    }
}

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Companion;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Services
{
    public class RelatorioEtapas
    {
        public string GerarListaEtapas(List<Etapas> listaEtapas)
        {
            QuestPDF.Settings.License =
                QuestPDF.Infrastructure.LicenseType.Community;

            string caminho = Path.Combine(Path.GetTempPath(),
                $"RelatorioEtapas_{Guid.NewGuid()}.pdf");

            Document.Create(contador => {

                contador.Page(page => {

                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Verdana));
                    //Ínicio do cabeçalho
                    page.Header().BorderBottom(1).PaddingBottom(5).Row(row =>
                    {
                        row.RelativeItem(1).Column(col => {

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
                        row.RelativeItem(1).AlignCenter().AlignMiddle().Text("Lista de Etapas").FontSize(14).Bold();
                        row.RelativeItem(1).AlignRight().AlignMiddle().Text(t => {

                            t.Span("Data: ").Bold();
                            t.Span(DateTime.Now.ToString("dd/MM/yyyy"));
                        });
                    });


                    //Conteúdo Central
                    page.Content().PaddingVertical(10).Table(table => {

                        table.ColumnsDefinition(columns => {

                            columns.ConstantColumn(100);
                            columns.RelativeColumn(4);
                            columns.RelativeColumn(6);


                        });

                        table.Header(header => {

                            header.Cell().BorderBottom(1).Text("ID").Bold();
                            header.Cell().BorderBottom(1).Text("NOME").Bold();
                            header.Cell().BorderBottom(1).Text("ORDEM").Bold();

                        });

                        foreach (var etapas in listaEtapas)
                        {
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapas.Id.ToString());
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapas.Nome ?? "-");
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapas.Ordem.ToString());
                        }
                    
                    });


                    //Rodapé
                    page.Footer().AlignCenter().Text(t => {
                        t.Span("Página ");
                        t.CurrentPageNumber();
                    });
                });
            }).GeneratePdf(caminho);

            return caminho;
        } 
    }
} 

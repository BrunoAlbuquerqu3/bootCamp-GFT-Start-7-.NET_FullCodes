using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deserializando.Models;
using SerializarC_Vendas.Models;
using Newtonsoft.Json;

DateTime dataatual = DateTime.Now;
Console.WriteLine("--------------------------------------");
Console.WriteLine("Deserializando Coleção  Vendas.JSON");
Console.WriteLine("====================================");

string conteudoArquivo = File.ReadAllText("Arquivos/VendasSerializando.Json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach  (Venda? venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
    $"Preço: {venda.Preco}, Data: {venda.DataVenda}");   
}



Console.WriteLine("--------------------------------------");
Console.WriteLine("Serialização Coleção .JSON");
Console.WriteLine("====================================");



List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material Escritorio", 25.00M, dataatual);
Vendas v2 = new Vendas(2, "Licença de Softw are", 110.00M, dataatual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/Vendas.Json", serializado);

Console.WriteLine(serializado);
 

using System.Xml;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXML
{
    class Program
    {
        static void CriarXmlDOM()
        {
            // Cria o XmlDocument
            XmlDocument contactsDocument = new XmlDocument();

            // Define a instrução de processamento do arquivo e o elemento raiz
            contactsDocument.AppendChild(contactsDocument.CreateProcessingInstruction
            ("xml", "version='1.0' encoding='UTF-8' standalone='yes'"));
            contactsDocument.AppendChild(contactsDocument.CreateElement("Contatos"));

            //Cria elemento filho do elemento raiz e o adiciona à raiz
            XmlElement contactElement = contactsDocument.CreateElement("Contato");
            contactsDocument.DocumentElement.AppendChild(contactElement);

            //Cria o elemento filho do elemento Contato, atribui um valor e o adiciona ao elemento
            XmlElement nameElement = contactsDocument.CreateElement("Nome");
            nameElement.InnerText = "Thiago Mônaco";
            contactElement.AppendChild(nameElement);

            //Cria elemento filho do elemento Contato e o adiciona ao elemento
            XmlElement phonesElement = contactsDocument.CreateElement("Telefones");
            contactElement.AppendChild(phonesElement);

            //Cria elemento filho do elemento Telefones, atribui um valor, um atributo e o adiciona  ao elemento
            XmlElement phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 9999-9999";
            phoneElement.SetAttribute("Tipo", "Celular");
            phonesElement.AppendChild(phoneElement);

            //Cria elemento filho do elemento Telefones, atribui um valor, um atributo e o adiciona  ao elemento
            phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 5555-5555";
            phoneElement.SetAttribute("Tipo", "Residencial");
            phonesElement.AppendChild(phoneElement);

            //Cria elemento filho do elemento Contato e o adiciona ao elemento
            XmlElement adressElement = contactsDocument.CreateElement("Endereco");
            contactElement.AppendChild(adressElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            XmlElement streetElement = contactsDocument.CreateElement("Logradouro");
            streetElement.InnerText = "R: Xpto, 1234";
            adressElement.AppendChild(streetElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            XmlElement districtElement = contactsDocument.CreateElement("Bairro");
            districtElement.InnerText = "Bairro XXX";
            adressElement.AppendChild(districtElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            XmlElement cityElement = contactsDocument.CreateElement("Cidade");
            cityElement.InnerText = "São Paulo";
            adressElement.AppendChild(cityElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            XmlElement stateElement = contactsDocument.CreateElement("Estado");
            stateElement.InnerText = "SP";
            adressElement.AppendChild(stateElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            XmlElement zipCodeElement = contactsDocument.CreateElement("CEP");
            zipCodeElement.InnerText = "01010-010";
            adressElement.AppendChild(zipCodeElement);

            //Adiciona outro elemento Contato ao XML:

            contactElement = contactsDocument.CreateElement("Contato");
            contactsDocument.DocumentElement.AppendChild(contactElement);

            //Cria elemento filho do elemento Contato, atribui um valor e o adiciona ao elemento
            nameElement = contactsDocument.CreateElement("Nome");
            nameElement.InnerText = "TPaulo Pedro";
            contactElement.AppendChild(nameElement);

            //Cria elemento filho do elemento Contato e o adiciona ao elemento
            phonesElement = contactsDocument.CreateElement("Telefones");
            contactElement.AppendChild(phonesElement);

            //Cria elemento filho do elemento Telefones, atribui um valor, um atributo e o adiciona  ao elemento
            phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 8888-8888";
            phoneElement.SetAttribute("Tipo", "Celular");
            phonesElement.AppendChild(phoneElement);

            //Cria elemento filho do elemento Telefones, atribui um valor, um atributo e o adiciona  ao elemento
            phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 8888-8888";
            phoneElement.SetAttribute("Tipo", "Residencial");
            phonesElement.AppendChild(phoneElement);

            //Cria elemento filho do elemento Contato e o adiciona ao elemento
            adressElement = contactsDocument.CreateElement("Endereco");
            contactElement.AppendChild(adressElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            streetElement = contactsDocument.CreateElement("Logradouro");
            streetElement.InnerText = "R: ABC, 1234";
            adressElement.AppendChild(streetElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            districtElement = contactsDocument.CreateElement("Bairro");
            districtElement.InnerText = "Bairro AAA";
            adressElement.AppendChild(districtElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            cityElement = contactsDocument.CreateElement("Cidade");
            cityElement.InnerText = "São Paulo";
            adressElement.AppendChild(cityElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            stateElement = contactsDocument.CreateElement("Estado");
            stateElement.InnerText = "SP";
            adressElement.AppendChild(stateElement);

            //Cria elemento filho do elemento Endereco, atribui um valor e o adiciona ao elemento
            zipCodeElement = contactsDocument.CreateElement("CEP");
            zipCodeElement.InnerText = "02020-020";
            adressElement.AppendChild(zipCodeElement);

            contactsDocument.Save(@"D:\Users\Kaio\Documents\Visual Studio 2015\Projects\Linq_e_Entity\Linq\LinqXML\Contatos1.xml");
            Console.WriteLine(@"Criando o arquivo XML com DOM em D:\Users\Kaio\Documents\Visual Studio 2015\Projects\Linq_e_Entity\Linq\LinqXML\Contatos1.xml");
        }

        static void CriarXmlLinq()
        {
            XElement contatos =
                new XElement("Contatos",
                    new XElement("Contato",
                        new XElement("Nome", "Thiago Mônaco"),
                        new XElement("Telefones",
                            new XElement("Telefone", "(11) 9999-9999",
                                new XAttribute("Tipo", "Celular")),
                            new XElement("Telefone", "(11) 5555-5555",
                                new XAttribute("Tipo", "Residencial"))
                        ),
                        new XElement("Endereco",
                            new XElement("Logradouro", "R: Xpto, 1234"),
                            new XElement("Bairro", "Bairro XXX"),
                            new XElement("Cidade", "São Paulo"),
                            new XElement("Estado", "SP"),
                            new XElement("CEP", "01010-010")
                        )
                    ),
                    new XElement("Contato",
                        new XElement("Nome", "Paulo Pedro"),
                        new XElement("Telefones",
                            new XElement("Telefone", "(11) 8888-8888",
                                new XAttribute("Tipo", "Celular")),
                            new XElement("Telefone", "(11) 4444-4444",
                                new XAttribute("Tipo", "Residencial"))
                        ),
                        new XElement("Endereco",
                            new XElement("Logradouro", "R: ABC, 1234"),
                            new XElement("Bairro", "Bairro AAA"),
                            new XElement("Cidade", "São Paulo"),
                            new XElement("Estado", "SP"),
                            new XElement("CEP", "02020-020")
                        )
                    )
                );

            contatos.Save(@"D:\Users\Kaio\Documents\Visual Studio 2015\Projects\Linq_e_Entity\Linq\LinqXML\Contatos2.xml");
            Console.WriteLine(@"Criando o arquivo XML com LINQ to XML em D:\Users\Kaio\Documents\Visual Studio 2015\Projects\Linq_e_Entity\Linq\LinqXML\Contatos2.xml");
        }

        static void Main(string[] args)
        {
            CriarXmlLinq();
            Console.ReadKey();

        }
    }
}

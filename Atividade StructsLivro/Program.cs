﻿using System;
using System.Linq.Expressions;

class Programa
{

    struct livro
    {
        public string titulo;
        public string autor;
        public int ano;
        public int patreleira;

    }

    static void cadastraLivro(List<livro> lista)
    {
        livro novoLivro = new livro();

        Console.Write("Digite o Título do livro:");
        novoLivro.titulo = Console.ReadLine();
        Console.Write("Digite o Autor do livro:");
        novoLivro.autor = Console.ReadLine();
        Console.Write("Digite o ano do livro:");
        novoLivro.ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a prateleira:");
        novoLivro.patreleira = Convert.ToInt32(Console.ReadLine());

        lista.Add(novoLivro);

    }

    static void procurarLivro(List<livro> lista, string tituloBusca)
    {
        int index = lista.Count();
        
        for(int i =0;i< index; i++)
        {
            if (lista[i].titulo.ToUpper().Contains(tituloBusca.ToUpper()))
            {
                Console.WriteLine("Livro encontrado!\n");
                Console.WriteLine($"{lista[i].titulo}");
                Console.WriteLine("Presente na prateleira: " + lista[i].patreleira);
            }
            else
            {
                Console.WriteLine("Livro não encontrado!");
            }
        }
    }
    static void listarLivros(List<livro> lista)
    {
        foreach(livro l in lista)
        {
            Console.WriteLine("Nome: " + l.titulo);
            Console.WriteLine("Autor: " + l.autor);
            Console.WriteLine("Ano: " + l.ano);
            Console.WriteLine("Prateleira: " + l.patreleira);
        }
    }

    static void listarPorAno(List<livro> lista, int anoBusca)
    {
        int index = lista.Count();

        for(int i=0; i< index; i++)
        {
            if (lista[i].ano > anoBusca)
            {
                Console.WriteLine($"Livros mais novos que o ano: {anoBusca}");
                Console.WriteLine("Nome:" + lista[i].titulo);
                Console.WriteLine("Autor:" + lista[i].autor);
                Console.WriteLine("Ano:" + lista[i].ano);
                Console.WriteLine("Prateleira" + lista[i].patreleira);

            }
            else 
            {
                Console.WriteLine("Não há livros após esse ano.");
            }
        }
    }
    static int menu()
    {
        int num;
        Console.WriteLine("*** Biblioteca ***");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Cadastrar Livros");
        Console.WriteLine("2 - Procurar por um livro"); 
        Console.WriteLine("3 - Listar os livros cadastrados");
        Console.WriteLine("4 - Ler um ano"); 

        num = Convert.ToInt32(Console.ReadLine());

        return num;
    }
    static void Main()
    {
        List<livro> lista = new List<livro>();
        int operador;
        bool program = true;


        do
        {
          
            operador = menu();
            switch (operador)
            {
                case 0:
                    program = false;
                    Console.WriteLine("Precione ENTER para sair...");
                    break;
                case 1:
                    Console.WriteLine("Cadastrar livro:");
                    cadastraLivro(lista);
                    break;
                case 2:
                    Console.WriteLine("Qual livro deseja procurar:");
                    string nome = Console.ReadLine();
                    procurarLivro(lista, nome);
                    break;
                case 3:
                    listarLivros(lista);
                    break;
                case 4:
                    Console.WriteLine("Digite o ano:");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    listarPorAno(lista, ano);
                    break;
            }
            Console.ReadKey();
            Console.Clear();

        } while (program);

        
        

    }

}
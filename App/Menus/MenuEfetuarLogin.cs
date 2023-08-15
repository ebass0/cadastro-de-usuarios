﻿using App.Modelos;

namespace App.Menus;

internal class MenuEfetuarLogin
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.Clear();
        Console.WriteLine("Login:");
        Console.Write("\nE-mail: ");
        string email = Console.ReadLine()!;
        Console.Write("Senha: ");
        string senha = Console.ReadLine()!;

        if(usuarios.ContainsKey(email))
        {
            Usuario usuario = usuarios[email];

            if(usuario.Senha == senha)
            {
                Console.Clear();
                Console.WriteLine("Login bem-sucedido!");
                //MenuExibirUsuario();
            }
            else
            {
                Console.WriteLine("\nSenha incorreta!");
                Thread.Sleep(1000);

                Console.Write("Deseja tentar novamente (S/N) ? ");
                string resposta = Console.ReadLine()!;

                if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Executar(usuarios);
                }
                else if (resposta.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        } 
        else
        {
            Console.WriteLine("E-mail não registrado!");
            
        }
    }
}
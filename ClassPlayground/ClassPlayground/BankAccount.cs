﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
     /*
        2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
     * Přidej třídě BankAccount čtyři proměnné    - accountNumber jako číslo účtu
     *                                            - holderName jako jméno osoby, které účet patří
     *                                            - currency jako měna, ve které je účet vedený
     *                                            - balance jako zůstatek na účtu
     * Přidej třídě BankAccount tři funkce      - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
     *                                          - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
     *                                            Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.
     *                                          - Transfer, která jako vstupní parametry přijme množství peněz a číslo účtu, na které se budou peníze posílat, a převede peníze
     *                                            z jednoho účtu na druhý(opět pouze pokud je na účtu, ze kterého převod jde, dostatek peněz)
     * Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry    - jméno majitele účtu a měnu, ve které bude účet vedený
     *                                                                            - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
     *                                                                              vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu
     *
     * 2) BONUS - Až vytvoříš BankAccount, přidej varianty funkcí výběru, vkladu a převodu s měnou jako vstupním parametrem, tedy pokud měna při vkladu/výběru(nebo měna účtu, na který se převádí)
     * je odlišná od měny, ve které je účet veden, zohledni to a správně vynásob peníze kurzem, který najdeš na internetu.Pro uložení kurzů si můžeš udělat novou statickou třídu,
     * ve které budeš mít public static float proměnné pojmenované podle toho, jaký kurz z jaké do jaké měny představují, a jeho hodnotu.
     */
    internal class BankAccount
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public int balance;

        public void Deposit(int deposit)
        {
            balance += deposit;
        }

        public void Withdraw(int withdraw)
        {
            if (withdraw > balance)
            {
                Console.WriteLine("Nemáš dost peněz DEMENTE!");
            }
            else
            {
            balance -= withdraw;
            }
        }

        public void Transfer(int transfer, int accountNumberForTransfer)
            {
                
            }
    }
}

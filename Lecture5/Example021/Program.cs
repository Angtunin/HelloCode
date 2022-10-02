﻿// "Ханойская башня" - увлекательная головоломка, придуманная французским математиком Эдуардом Люка в 1883 году. 
// На одном из трёх стержней надеты кольца - меньшие на больших. 
// Необходимо используя вспомогательный (центральный) стержень перенести пирамидку с левого стержня на правый. 
// За раз можно переносить только одно кольцо, причём нельзя класть большее кольцо на меньшее. 
// Постарайтесь найти решение головоломки за как можно меньшее число ходов.

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
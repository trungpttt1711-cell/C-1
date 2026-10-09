using System;
using System.Text.RegularExpressions;

string hoTen = "Le          Duong             Bao            Anh";

hoTen = hoTen.Trim();
hoTen = Regex.Replace(hoTen, @"\s+", " ");

string pattern = @"^\p{Lu}\p{Ll}+(?: \p{Lu}\p{Ll}+)*$";

if (Regex.IsMatch(hoTen, pattern))
{
    Console.WriteLine("Ho ten hop le");
}
else
{
    Console.WriteLine("Ho ten khong hop le");
}
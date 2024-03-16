using System;
using System.IO;


// See https://aka.ms/new-console-template for more information

namespace Pr{
  class Program
  {
static void Main(string[] args){
      Console.WriteLine("\nLab 8");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { one();  break;}
    //case 2: { task2();  break;}
    //case 3: { task3();  break;}
  }
Console.WriteLine("Lab#8 ");



static void one(){

string file = File.ReadAllText("1.txt");

string[] str = new string[] {""};

string [] symb= new string[] {":",",","!","?","-"};

for(int i=0; i<symb.Length;i++){
    file=file.Replace(symb[i], "");
}

str = file.Split(' ');


List<string> result = new List<string>();

foreach (string i in str){
    foreach (char s in i){
        if (s == '@'){
            result.Add(i);
        }
    }
}


foreach (string line in result){
File.WriteAllLines("2.txt",result);
}

Console.WriteLine("\nEmail: "+File.ReadAllText("2.txt"));


Console.WriteLine("Count: "+result.Count);

Console.WriteLine("To change: ");
string ch = Console.ReadLine();

for (int i = 0;i < str.Length; i++)
for (int j = 0;j < result.Count; j++){
        if (str[i]==result[j]){
            str[i]=ch;
    }
}

Console.WriteLine("Change: ");
for (int i = 0;i < str.Length; i++) {
    Console.Write(str[i]+" ");
}

Console.WriteLine("\n");

}

}}}
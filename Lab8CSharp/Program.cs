using System;
using System.IO;
using System.Text.RegularExpressions;


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
    case 2: { two();  break;}
    case 3: { three();  break;}
    case 4: { four();  break;}
    case 5: { five();  break;}
    //case 6: { six();  break;}
    //case 7: { seven();  break;}
    //case 8: { eight();  break;}
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
}
static void two(){
    string file = File.ReadAllText("3.txt");

string[]str= Regex.Split(file, @"\D+");

List<int> numb = new List<int>();

for(int i = 1;i < str.Length-1;i++){
    numb.Add(Convert.ToInt32(str[i]));
}

int max=0;
 for (int i = 0; i < numb.Count; i++){
    if(numb[i] > max){
        max = numb[i];
    }
} 

File.WriteAllText("4.txt",max.ToString());

Console.WriteLine("\nMax: "+File.ReadAllText("4.txt"));

}

static void three(){
    
string file = File.ReadAllText("5.txt");

string[] str = new string[] {};

string [] symb= new string[] {":",",","!","?","-"};

for(int i=0; i<symb.Length;i++){
    file=file.Replace(symb[i], "");
}

str = file.Split(' ');

List<int> n=new List<int>();

int k=0;
foreach (string i in str){
    foreach (string j in str){
        if(j==i) k++;
    }
    n.Add(k);
    k=0;
}

List<int> pos=new List<int>();
for(int i=0; i<n.Count;i++){
    if (n[i]==1){
        pos.Add(i);
    }
}

k=0;

foreach(int j in pos){
k=0;
foreach(string i in str){
    if(k==j){
        file=file.Replace(i," ");
    }
    k++;
}}

Console.WriteLine("N: ");
foreach (int i in n){
Console.WriteLine(i);
}

Console.WriteLine("Str: ");
foreach (string i in str){
Console.WriteLine(i);
}

File.WriteAllText("6.txt",file);


Console.WriteLine("\nResult: "+File.ReadAllText("6.txt"));


Console.WriteLine("\n");

}

static void four(){

    
Console.WriteLine("N: ");
 int n = Convert.ToInt32(Console.ReadLine());
double[] numb=new double[n];

for(int i=0; i<n;i++){
numb[i]= Convert.ToDouble(Console.Read());
}


foreach (double i in numb){
File.WriteAllText("7.csv",i.ToString());
}

Console.WriteLine("\nFile: "+File.ReadAllText("7.csv"));


Console.WriteLine("Range: ");
 int start = Convert.ToInt32(Console.ReadLine());
 int end = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nResult: ");
for (int i = 0; i < start-1; i++){
    Console.Write(numb[i]+" ");
}
for (int i = end; i < n; i++){
    Console.Write(numb[i]+" ");
}
Console.WriteLine("\n");
}

static void five(){

string dir = @"D:\Chnu\csharplab8-ValentinaOb\Lab8CSharp\Student1";
string dir1 = @"D:\Chnu\csharplab8-ValentinaOb\Lab8CSharp\Student2";
string dir2 = @"D:\Chnu\csharplab8-ValentinaOb\Lab8CSharp\Student1\1.txt";
string dir3 = @"D:\Chnu\csharplab8-ValentinaOb\Lab8CSharp\Student1\2.txt";
string dir4 = @"D:\Chnu\csharplab8-ValentinaOb\Lab8CSharp\Student2\3.txt";
string dir5 = @"D:\Chnu\csharplab8-ValentinaOb\Lab8CSharp\ALL";
Directory.CreateDirectory(dir);
Directory.CreateDirectory(dir1);

/*
if (!Directory.Exists("Student2"))
{
    Directory.CreateDirectory("Student2");
}
*/

File.Create(dir2);
string t1="Шевченко Степан Іванович, 2001 року народження, місце проживання м. Суми";
File.WriteAllText("Student1/1.txt",t1);

File.Create(dir3);
string t2="Комар Сергій Федорович, 2000 року народження, місце проживання м. Київ";
File.WriteAllText("Student2/2.txt",t2);

File.Create(dir4);
File.WriteAllText("Student2/2.txt","Student1/1.txt");
File.WriteAllText("2.txt","\n");
File.WriteAllText("Student2/2.txt","Student1/2.txt");


Console.WriteLine("\nInfo 1: ");
Console.WriteLine(Directory.GetCreationTime(dir));
Console.WriteLine(Directory.Exists(dir));
Console.WriteLine(Directory.GetLastAccessTime(dir));
Console.WriteLine(Directory.GetLastWriteTime(dir));
Console.WriteLine(Directory.GetFiles(dir));


Console.WriteLine("\nInfo 2: ");
Console.WriteLine(Directory.GetCreationTime(dir1));
Console.WriteLine(Directory.Exists(dir1));
Console.WriteLine(Directory.GetLastAccessTime(dir1));
Console.WriteLine(Directory.GetLastWriteTime(dir1));
Console.WriteLine(Directory.GetFiles(dir1));


File.Move(dir3, dir1);
File.Copy(dir2, dir1);
Directory.Move(dir1, dir5);
Directory.Delete(dir);

Console.WriteLine("\nInfo 3: ");
Console.WriteLine(Directory.GetCreationTime(dir5));
Console.WriteLine(Directory.Exists(dir5));
Console.WriteLine(Directory.GetLastAccessTime(dir5));
Console.WriteLine(Directory.GetLastWriteTime(dir5));
Console.WriteLine(Directory.GetFiles(dir5));


}


}}
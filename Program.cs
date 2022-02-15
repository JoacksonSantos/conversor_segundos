int n , horas, minutos,segundos;
n= int.Parse(Console.ReadLine());

if(n >= 60){
   segundos = n % 60;
   n = n / 60;
}else{
    segundos = n;
    n =0;
}

if(n < 60){
    minutos = n;
    n =0;
}else{
    minutos = n % 60;
    n = n / 60;
}

if(n < 60){
    horas = n;
    n =0;
}else{
    horas = n % 60;
    n = n / 60;
}

Console.WriteLine(horas+":"+minutos+":"+segundos);
// See https://aka.ms/new-console-template for more information
double minriazi = 0; double mintafsir = 0; double minzaban = 0; double minkarrahshoghli = 0; double minfarsi = 0; double minbarnamesazi = 0;
double maxriazi = 20; double maxtafsir = 20; double maxzaban = 20; double maxkarrahshoghli = 20; double maxfarsi = 20; double maxbarnamesazi = 20;

double minfizik = 0; double minshimi = 0; double minhonar = 0; double mingosaste = 0;
double maxfizik = 20; double maxshimi = 20; double maxhonar = 20; double maxgasaste = 20;






Console.WriteLine("welcom");

Console.WriteLine("nomre darse riazi ra vared konid");
Double riazi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" nomre darse tafsir ra vared ");
double tafsir = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse zaban ra vared konid");
double zaban = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse kar rah shoghl ra vared konid");
double karrahshoghli = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse farsi ra vared konid");
double farsi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse barname sazi ra vared konid");
double barnamesazi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse fizik");
double fizik = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse gosaste");
double gosaste = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse shimi");
double shimi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed9 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nomre darse honar");
double honar = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in dars chand vahed ast");
int vahed10 = Convert.ToInt32(Console.ReadLine());

{
    double x = (riazi) * (vahed1) + (tafsir) * (vahed2) + (zaban) * (vahed3) + (karrahshoghli) * (vahed4) + (farsi) * (vahed5) + (barnamesazi) * (vahed6) + (fizik) * (vahed7) + (gosaste) * (vahed8) + (shimi) * (vahed9) + (honar) * (vahed10);
    double z = x / (vahed1 + vahed2 + vahed3 + vahed4 + vahed5 + vahed6 + vahed7 + vahed8 + vahed9 + vahed10);
    Console.WriteLine("moadel shoma =" + z);

}
// amirhosseine azarakhsh tamrine 3//

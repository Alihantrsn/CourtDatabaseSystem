// See https://aka.ms/new-console-template for more information


using Lawyer.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.X509Certificates;

using Lawyer;



   
    
        Initilazior.Build();
        using (var _context = new AppDbContext())
        {

    var Judges = new Judge()
    {
        Name = "osman",
        Lname = "hakim",
        Case = new Case()
        {
            Case_CourtHouse_Name = "Kadıköy Adliye",
            Case_Court_Name = "5.salon",
            Case_Date = "Salı",
            Case_Defendent_Name = "Alihan",
            Case_File_Number = 56,
            Case_PlaintiffsName = "Ali",
            Case_Type = "Şiddet",
        }

    };
    
    Judges.Court.Add(new Court()
    {
        Court_Name=Judges.Case.Case_Court_Name,
    });
   Judges.Case.Costumers.Add(new Costumers() {
        Costumer_Name=Judges.Case.Case_Court_Name
        ,Case_Number=Judges.Case.Case_File_Number
        ,Which_Court=Judges.Case.Case_Court_Name
        ,Which_C_House=Judges.Case.Case_CourtHouse_Name
        ,Case_Type=Judges.Case.Case_Type
    });
    Judges.Case.Lawyers.Add(new Lawyers()
    {
        Name = "Mehmetl Ali",
        Lname="*****",
        Sgk_No=23423,
        Adresss="Istanbul",
        B_date="2000",
        B_place="Mersin",
        H_Phone_Number=123123,
        Lawyer_D_Number=11241,
        P_Number=34536,
    });
    _context.Add(Judges);
    Console.WriteLine("");
    await _context.SaveChangesAsync();
    Console.WriteLine("İşlem yapıldı");


    //_context.CourtsHouse.Add(new CourtHouse() { CourtHouse_Name = "Kadıköy Adliye", CourtHouse_Adress = "Bostancı Marmaray" });

    //var Case = _context.Entry<Case>(x => x.Case_Type == costumer.Case_Type,costumer.Which_Court,costumer.Which_C_House);
    //_context.Case.Add(new Case() {Case_CourtHouse_Name=new CourtHouse()            });
    // var CourtHouse = new CourtHouse() { CourtHouse_Name="Kadıköy Adliye",CourtHouse_Adress="Bostancı Marmaray"};
    //var Court = new Court() { Court_Name="5.salon"};
    //_context.Courts.Add(new Court() { Court_Name ="5.Salon" });
    //var Case = new Case() { Case_CourtHouse_Name = CourtHouse.CourtHouse_Name
    //    ,Case_Court_Name=Court.Court_Name
    //    ,Case_File_Number=55
    //    ,Case_Date="Pazartesi"
    //    ,Case_Defendent_Name="Alihan"
    //    ,Case_PlaintiffsName="Ali"
    //    ,Case_Type="Şiddet"

    //};
    //_context.Lawyers.Add(new Lawyers()
    //{
    //    Name = "Mehmet Ali"
    //    ,
    //    Lname = "Kaçar"
    //    ,
    //    Adresss = "Istanbul"
    //    ,
    //    B_place = "Mersin"
    //    ,
    //    Lawyer_D_Number = 6
    //    ,
    //    P_Number = 123123
    //    ,
    //    Sgk_No = 5453
    //    ,
    //    B_date = "2000"
    //    ,
    //    H_Phone_Number = 1231241,
    //    Case = new () {}

    //Case=new Case() {Case_CourtHouse_Name="Kadıköy adliye"
    //,Case_Date="Pazartesi"
    //,Case_Court_Name="5.salon"
    //,Case_Defendent_Name="Alihan",
    //Case_File_Number=5
    //,Case_PlaintiffsName="Ali",
    //Case_Type="Şiddet",
    //Judges=new List<Judge>
    // }) ; 



    //_context.Add( CourtHouse );
    //_context.Add( Court );
    //_context.Add( Case );
    //_context.Add(Case);




}
    

//var teacher = new Teacher() { Name = "Fizik", Lname = "Hocası",Students=new List<Student> () { 



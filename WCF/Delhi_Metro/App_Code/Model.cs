﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class FareList
{
    public int Id { get; set; }
    public string SourceStation { get; set; }
    public string DestinationStation { get; set; }
    public double Fare { get; set; }
}

public partial class Ticket
{
    public int Id { get; set; }
    public string MobileNumber { get; set; }
    public int Ticket_Count { get; set; }
    public string SourceStation { get; set; }
    public string DestinationStation { get; set; }
    public double TotalFare { get; set; }
    public string Status { get; set; }
}

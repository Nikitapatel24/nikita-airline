using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Flight
/// </summary>
public class Flight
{
    public string fId { get; set; }
    public string fDate { get; set; }
    public string fTime { get; set; }
    public string fFrom { get; set; }
    public string fTo { get; set; }

    public Flight(string fId, string fDate, string fTime, string fFrom, string fTo)
    {
        this.fId = fId;
        this.fDate = fDate;
        this.fTime = fTime;
        this.fFrom = fFrom;
        this.fTo = fTo;
    }
}
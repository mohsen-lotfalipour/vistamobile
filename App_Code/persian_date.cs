using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for persian_date
/// </summary>
public class persian_date
{
    static System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
	public persian_date()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string Persian_date_now()
    {     

        string date = pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now);
        return date;
    }
    public static string Persian_date_toshamsi(string miladi_date)//persian_date.Persian_date_toshamsi("2014/05/23")
    {
        DateTime dt = DateTime.Parse(miladi_date);
        string shamsi_date = pc.GetYear(dt) + "/" + pc.GetMonth(dt) + "/" + pc.GetDayOfMonth(dt);
        return shamsi_date;
    }
    public static string miladi_date_now()
    {
        string date = DateTime.Now.ToShortDateString();
        return date;
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Client
/// </summary>
class UserData
{

    public int userId { get; set; }
    public String title { get; set; }
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String email { get; set; }
    public String dob { get; set; }
    public String phone { get; set; }
    public String address { get; set; }
    public String password { get; set; }


    //this is the public paramterized constructor of the class
    public UserData(int userId, String title, String firstName, String lastName, String dob, String email, String phone, String address, String password){
		this.userId = userId;
        this.title = title;
		this.firstName = firstName;
		this.lastName = lastName;
		this.dob = dob;
		this.email = email;
		this.phone = phone;
		this.address = address;
        this.password = password;
	}

}
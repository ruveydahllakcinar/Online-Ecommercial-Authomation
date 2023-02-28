# Online Commercial Automation with Asp.Net Mvc5

In this project, I created panels related to online commercial automation and developed a panel system that includes all trade-related fields such as customer, personnel, invoice, sales, statistics.

Thanks to this panel;
- As an administrator you have access to each page. But if you're just an employee, you can see certain locations because I used a role in this project. After logging in, you can see the pages according to the authorization given to you.

## Frameworks Used

* .NET Framework (4.6.1)
* Entity Framework (6.0.0)

## Project Setup

* First you need to [install](https://visualstudio.microsoft.com/tr/).

* You must select the ASP.NET Web Application (.NET Framework) option and select the version. Ins. I developed the project with version 4.6.1.

* After choosing your project name and version, a screen comes up where you can choose how to develop the application in the next step. Since we will use MVC, we choose the MVC option.

* Check MySQL as datastore. I created my classes in Model. I submitted this to the database.

---



## What is included in the project?

* There is a page where products are added, deleted and updated according to categories.

---

<img src="Online Commercial Authomation/readmeimages/category.png"  width="900" height="300">

---

* I created a page where products are added, deleted, updated and sold. In this way, you can see how many products are left in stock and examine the buying and selling prices.

---

<img src="Online Commercial Authomation/readmeimages/product.png"  width="600" height="300">

---

* When you are going to sell, you can select which employee is selling and make sales according to the customer ID. The number of units you sell is deducted from the stock amount.

---

<img src="Online Commercial Authomation/readmeimages/makeasale.png" width="600" height="300">

---

* You can see and add your personnel and you can reach the details about the personnel.

---

<img src="Online Commercial Authomation/readmeimages/employee.png" width="600" height="300">

---

<img src="Online Commercial Authomation/readmeimages/employeedetail.png" width="600" height="300">

---


*  Think of a sale page where you observe the sales you make... Thanks to this page, you can observe the details of which employee sold which product in which category and how many units to which customers.

<img src="Online Commercial Authomation/readmeimages/salesdetail.png" width="600" height="300">

---

* Invoices are of great importance for the products sold. That's why I reserved a place for invoices in this project. You can see the details according to the invoice numbers, add new invoices and see the data with a pop-up window.
---

<img src="Online Commercial Authomation/readmeimages/invoice.png" width="600" height="300">

---
* I have created a field that allows the cargo details to be seen by creating a tracking code specific to the cargo.

<img src="Online Commercial Authomation/readmeimages/cargo.png" width="600" height="300">

---

<img src="Online Commercial Authomation/readmeimages/cargodetails.png" width="600" height="300">

---

## Project Controller

I have about 20 controllers in my project. I have a custom controller for each viewport. In these areas, besides the basic crud operations, there is an area where I perform role-playing operations.
<img src="Online Commercial Authomation/readmeimages/adminrole.png" width="600" height="300">


### Category Controller

* I wrote the basic CRUD operations that I can perform listing, adding, deleting and updating operations. 

---


### Cargo Controller

* While naming the cargo, I used the random parameter so that the same names do not coincide, so that cargo numbers will be created without coinciding with each other.

---


<img src="Online Commercial Authomation/readmeimages/cargo.png" width="600" height="300">


---


### Chart Controller

* I created a graphic area where we can observe the stock status of the products sold, how much they are sold, whether there is an increase or decrease in sales.

<img src="Online Commercial Authomation/readmeimages/charts.png" width="600" height="300">

---


### Error Pages

* Hata alan sayfalara özel tasarım ve controllerını da oluşlturmayı unutmadım. Açılmayan sayfa olduğu zaman 404 hatası, yetkilendirme işleminden sonra yetkisi bulunmayan kullanıcıların karşılaştığı 403 hatası ve kullanıcının gönderdiği istek hatalı olduğunda karşılaşacağı hatadır.

---

<img src="Online Commercial Authomation/readmeimages/errorpages.png" width="600" height="600">

---

### Login Controller

* The codes I wrote in the controller in the project they did were also written differently because the fields where the employees and users log in are different. Because I have separate tables in sql table.

<img src="Online Commercial Authomation/readmeimages/login.png" width="600" height="300">

---





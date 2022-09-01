using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightTicketReservation.Migrations
{
    public partial class feroz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "a_employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_a_employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ajay_Employee1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    salary = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajay_Employee1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ajay_SBAccount",
                columns: table => new
                {
                    accountNumber = table.Column<int>(type: "int", nullable: false),
                    customerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    customerAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    currentBalance = table.Column<double>(type: "float", nullable: true),
                    maxBalance = table.Column<double>(type: "float", nullable: true),
                    image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajay_SBAccount", x => x.accountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Ajay_SBTransaction1",
                columns: table => new
                {
                    transactionId = table.Column<int>(type: "int", nullable: false),
                    transactionDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    accountNumber = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: true),
                    transactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajay_SBTransaction1", x => x.transactionId);
                });

            migrationBuilder.CreateTable(
                name: "Avi_BookingDetails",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    RoutId = table.Column<int>(type: "int", nullable: true),
                    Doj = table.Column<DateTime>(type: "datetime", nullable: false),
                    NumberOfPass = table.Column<int>(type: "int", nullable: false),
                    TotalValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avi_BookingDetails", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "Avi_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CurrentBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avi_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Avi_SBTransaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avi_SBTransaction", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "Bhramar_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CurrentAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CurrentBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bhramar_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Bhramar_SBTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bhramar_SBTransaction", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    bookingid = table.Column<int>(type: "int", nullable: false),
                    flightid = table.Column<int>(type: "int", nullable: true),
                    routeid = table.Column<int>(type: "int", nullable: true),
                    doj = table.Column<DateTime>(type: "datetime", nullable: true),
                    numberofpassengers = table.Column<int>(type: "int", nullable: true),
                    totalvalue = table.Column<double>(type: "float", nullable: true),
                    customerid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails", x => x.bookingid);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails_Abhishek",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    Doj = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Noofpassanger = table.Column<int>(type: "int", nullable: false),
                    Totalvalue = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BookingId", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails_Ajay",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false),
                    flightId = table.Column<int>(type: "int", nullable: true),
                    routeId = table.Column<int>(type: "int", nullable: true),
                    customerId = table.Column<int>(type: "int", nullable: true),
                    doj = table.Column<DateTime>(type: "datetime", nullable: true),
                    numberOfPassengers = table.Column<int>(type: "int", nullable: true),
                    totalValue = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails_Ajay", x => x.bookingId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    customerid = table.Column<int>(type: "int", nullable: false),
                    customername = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.customerid);
                });

            migrationBuilder.CreateTable(
                name: "darshanSBAccount",
                columns: table => new
                {
                    accountNumber = table.Column<int>(type: "int", nullable: false),
                    customerName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    customerAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    currentBalance = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_darshanSBAccount", x => x.accountNumber);
                });

            migrationBuilder.CreateTable(
                name: "darshanSBTransaction",
                columns: table => new
                {
                    transactionId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    transactionDate = table.Column<DateTime>(type: "date", nullable: true),
                    accountNumber = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    transactionType = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_darshanSBTransaction", x => x.transactionId);
                });

            migrationBuilder.CreateTable(
                name: "DemoImageDb",
                columns: table => new
                {
                    ProductName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ImageSource = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Divyansh_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    customername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    customeraddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    currentbalance = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divyansh_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Divyansh_SBTransaction",
                columns: table => new
                {
                    transactionid = table.Column<int>(type: "int", nullable: false),
                    transactiondate = table.Column<DateTime>(type: "date", nullable: true),
                    accountnumber = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    transactiontype = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divyansh_SBTransaction", x => x.transactionid);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Doj = table.Column<DateTime>(type: "date", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Eid);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Yash",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(name: "Full Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    DateOfJoining = table.Column<DateTime>(name: "Date Of Joining", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Yash", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FlightDetails",
                columns: table => new
                {
                    flightid = table.Column<int>(type: "int", nullable: false),
                    flightname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    destination = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    departuretime = table.Column<DateTime>(type: "datetime", nullable: true),
                    arrivaltime = table.Column<DateTime>(type: "datetime", nullable: true),
                    totalcapacity = table.Column<int>(type: "int", nullable: true),
                    costperseat = table.Column<double>(type: "float", nullable: true),
                    imagepath = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetails", x => x.flightid);
                });

            migrationBuilder.CreateTable(
                name: "harish_1",
                columns: table => new
                {
                    employee_number = table.Column<int>(type: "int", nullable: false),
                    employee_name = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id_pk", x => x.employee_number);
                });

            migrationBuilder.CreateTable(
                name: "harish_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_harish_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "harish_SBTransaction",
                columns: table => new
                {
                    t_id = table.Column<int>(type: "int", nullable: false),
                    t_date = table.Column<DateTime>(type: "date", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    t_type = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_harish_SBTransaction", x => x.t_id);
                });

            migrationBuilder.CreateTable(
                name: "Harsh_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CurrentBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harsh_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Harsh_SBTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harsh_SBTransaction", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Jivika_SBAccount",
                columns: table => new
                {
                    id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    account_no = table.Column<int>(type: "int", nullable: true),
                    customer_name = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    customer_address = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    current_balance = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jivika_SBAccount", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Jivika_SBTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    dot = table.Column<DateTime>(type: "datetime", nullable: true),
                    account_no = table.Column<int>(type: "int", nullable: true),
                    balance = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jivika_SBTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lekhana_SBAcc",
                columns: table => new
                {
                    acc_number = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Lekhana___A24910AB202506CF", x => x.acc_number);
                });

            migrationBuilder.CreateTable(
                name: "Lekhana_SBTran",
                columns: table => new
                {
                    t_id = table.Column<int>(type: "int", nullable: false),
                    accno = table.Column<int>(type: "int", nullable: false),
                    amt = table.Column<int>(type: "int", nullable: false),
                    t_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    t_date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lekhana_sbtran", x => x.t_id);
                });

            migrationBuilder.CreateTable(
                name: "Manisha",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manisha", x => x.Eid);
                });

            migrationBuilder.CreateTable(
                name: "Manisha_Employee",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Doj = table.Column<DateTime>(type: "datetime", nullable: true),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manisha_Employee", x => x.Eid);
                });

            migrationBuilder.CreateTable(
                name: "Manisha_SBAccount",
                columns: table => new
                {
                    Accno = table.Column<int>(type: "int", nullable: false),
                    Bal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manisha_SBAccount", x => x.Accno);
                });

            migrationBuilder.CreateTable(
                name: "Manisha_SBTransaction",
                columns: table => new
                {
                    TransID = table.Column<int>(type: "int", nullable: false),
                    Accno = table.Column<int>(type: "int", nullable: true),
                    Amt = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    TransType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manisha_SBTransaction", x => x.TransID);
                });

            migrationBuilder.CreateTable(
                name: "PracticeTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    product_name = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    image = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ravi_SBAccount",
                columns: table => new
                {
                    AccountNo = table.Column<int>(name: "Account No", type: "int", nullable: false),
                    CustomerName = table.Column<string>(name: "Customer Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(name: "Customer Address", type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Currentbalance = table.Column<double>(name: "Current balance", type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ravi_SBAccount", x => x.AccountNo);
                });

            migrationBuilder.CreateTable(
                name: "Ravi_SBTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(name: "Transaction Id", type: "int", nullable: false),
                    AccountNo = table.Column<int>(name: "Account No", type: "int", nullable: true),
                    TransactionType = table.Column<string>(name: "Transaction Type", type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TransactionDate = table.Column<DateTime>(name: "Transaction Date", type: "date", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ravi_SBTransaction", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Ritik_Employee",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Doj = table.Column<DateTime>(type: "date", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Ritik_SBAcoount",
                columns: table => new
                {
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentBalance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritik_SBAcoount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Ritik_SBTransaction",
                columns: table => new
                {
                    TransactionID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritik_SBTransaction", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "RouteDetails",
                columns: table => new
                {
                    routeid = table.Column<int>(type: "int", nullable: false),
                    flightid = table.Column<int>(type: "int", nullable: true),
                    routedesc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteDetails", x => x.routeid);
                });

            migrationBuilder.CreateTable(
                name: "Sarwat_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CustomerAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CustomerBalance = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sarwat_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "Sarwat_SBTransaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: true),
                    AccountNumber = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sarwat_SBTransaction", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "SB_Account_Yash",
                columns: table => new
                {
                    AccountNumber = table.Column<string>(name: "Account Number", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CustomerName = table.Column<string>(name: "Customer Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(name: "Customer Address", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CurrentBalance = table.Column<decimal>(name: "Current Balance", type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SB_Account_Yash", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "SB_Transaction_Yash",
                columns: table => new
                {
                    TransactionID = table.Column<string>(name: "Transaction ID", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TransactionDate = table.Column<DateTime>(name: "Transaction Date", type: "datetime", nullable: false),
                    AccountNumber = table.Column<string>(name: "Account Number", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SB_Transaction_Yash", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "SBAccount_Abhishek",
                columns: table => new
                {
                    AccNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AccNo", x => x.AccNo);
                });

            migrationBuilder.CreateTable(
                name: "SBAccount_Amresh",
                columns: table => new
                {
                    AccNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBAccount_Amresh", x => x.AccNo);
                });

            migrationBuilder.CreateTable(
                name: "SBAccount_sankalp",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    CreditScore = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBAccount_sankalp", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "SBAccount_Shaifali",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBAccount_Shaifali", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "sbLoan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    toAccount = table.Column<long>(type: "bigint", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    durationInDays = table.Column<int>(type: "int", nullable: false),
                    intrest = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sbLoan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SBTransaction_Abhishek",
                columns: table => new
                {
                    TransactionId = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    AccountNumber = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TransactionId", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "SBTransaction_Amresh",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBTransaction_Amresh", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "SBTransaction_sankalp",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBTransaction_sankalp", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "SBTransaction_Shaifali",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBTransaction_Shaifali", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "shan_SBAccount",
                columns: table => new
                {
                    accountNumber = table.Column<int>(type: "int", nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    customerAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    currentBalance = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shan_SBAccount", x => x.accountNumber);
                });

            migrationBuilder.CreateTable(
                name: "shan_SBTransaction",
                columns: table => new
                {
                    transactionID = table.Column<int>(type: "int", nullable: false),
                    accountNumber = table.Column<int>(type: "int", nullable: false),
                    transactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    transactionType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "shivam",
                columns: table => new
                {
                    Empid = table.Column<int>(type: "int", nullable: false),
                    Empname = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shivam_1", x => x.Empid);
                });

            migrationBuilder.CreateTable(
                name: "shivamsbaccount",
                columns: table => new
                {
                    Accountnumber = table.Column<int>(type: "int", nullable: false),
                    Customername = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: false),
                    Customeraddress = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: false),
                    Currentbalance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shivamsbaccount", x => x.Accountnumber);
                });

            migrationBuilder.CreateTable(
                name: "shivamsbtransaction",
                columns: table => new
                {
                    transactionid = table.Column<int>(type: "int", nullable: false),
                    transationdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Accountnumber = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    transactiontype = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shivamsbtransaction_1", x => x.transactionid);
                });

            migrationBuilder.CreateTable(
                name: "sundaram_SBAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sundaram_SBAccount", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "sundaram_SBTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sundaram_SBTransaction", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<long>(type: "bigint", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "trasferFunds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromAccount = table.Column<long>(type: "bigint", nullable: false),
                    toAccount = table.Column<long>(type: "bigint", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trasferFunds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Trial",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trial", x => x.Eid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "a_employee");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "Ajay_Employee1");

            migrationBuilder.DropTable(
                name: "Ajay_SBAccount");

            migrationBuilder.DropTable(
                name: "Ajay_SBTransaction1");

            migrationBuilder.DropTable(
                name: "Avi_BookingDetails");

            migrationBuilder.DropTable(
                name: "Avi_SBAccount");

            migrationBuilder.DropTable(
                name: "Avi_SBTransaction");

            migrationBuilder.DropTable(
                name: "Bhramar_SBAccount");

            migrationBuilder.DropTable(
                name: "Bhramar_SBTransaction");

            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "BookingDetails_Abhishek");

            migrationBuilder.DropTable(
                name: "BookingDetails_Ajay");

            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.DropTable(
                name: "darshanSBAccount");

            migrationBuilder.DropTable(
                name: "darshanSBTransaction");

            migrationBuilder.DropTable(
                name: "DemoImageDb");

            migrationBuilder.DropTable(
                name: "Divyansh_SBAccount");

            migrationBuilder.DropTable(
                name: "Divyansh_SBTransaction");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Employee_Yash");

            migrationBuilder.DropTable(
                name: "FlightDetails");

            migrationBuilder.DropTable(
                name: "harish_1");

            migrationBuilder.DropTable(
                name: "harish_SBAccount");

            migrationBuilder.DropTable(
                name: "harish_SBTransaction");

            migrationBuilder.DropTable(
                name: "Harsh_SBAccount");

            migrationBuilder.DropTable(
                name: "Harsh_SBTransaction");

            migrationBuilder.DropTable(
                name: "Jivika_SBAccount");

            migrationBuilder.DropTable(
                name: "Jivika_SBTransaction");

            migrationBuilder.DropTable(
                name: "Lekhana_SBAcc");

            migrationBuilder.DropTable(
                name: "Lekhana_SBTran");

            migrationBuilder.DropTable(
                name: "Manisha");

            migrationBuilder.DropTable(
                name: "Manisha_Employee");

            migrationBuilder.DropTable(
                name: "Manisha_SBAccount");

            migrationBuilder.DropTable(
                name: "Manisha_SBTransaction");

            migrationBuilder.DropTable(
                name: "PracticeTable");

            migrationBuilder.DropTable(
                name: "Ravi_SBAccount");

            migrationBuilder.DropTable(
                name: "Ravi_SBTransaction");

            migrationBuilder.DropTable(
                name: "Ritik_Employee");

            migrationBuilder.DropTable(
                name: "Ritik_SBAcoount");

            migrationBuilder.DropTable(
                name: "Ritik_SBTransaction");

            migrationBuilder.DropTable(
                name: "RouteDetails");

            migrationBuilder.DropTable(
                name: "Sarwat_SBAccount");

            migrationBuilder.DropTable(
                name: "Sarwat_SBTransaction");

            migrationBuilder.DropTable(
                name: "SB_Account_Yash");

            migrationBuilder.DropTable(
                name: "SB_Transaction_Yash");

            migrationBuilder.DropTable(
                name: "SBAccount_Abhishek");

            migrationBuilder.DropTable(
                name: "SBAccount_Amresh");

            migrationBuilder.DropTable(
                name: "SBAccount_sankalp");

            migrationBuilder.DropTable(
                name: "SBAccount_Shaifali");

            migrationBuilder.DropTable(
                name: "sbLoan");

            migrationBuilder.DropTable(
                name: "SBTransaction_Abhishek");

            migrationBuilder.DropTable(
                name: "SBTransaction_Amresh");

            migrationBuilder.DropTable(
                name: "SBTransaction_sankalp");

            migrationBuilder.DropTable(
                name: "SBTransaction_Shaifali");

            migrationBuilder.DropTable(
                name: "shan_SBAccount");

            migrationBuilder.DropTable(
                name: "shan_SBTransaction");

            migrationBuilder.DropTable(
                name: "shivam");

            migrationBuilder.DropTable(
                name: "shivamsbaccount");

            migrationBuilder.DropTable(
                name: "shivamsbtransaction");

            migrationBuilder.DropTable(
                name: "sundaram_SBAccount");

            migrationBuilder.DropTable(
                name: "sundaram_SBTransaction");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "trasferFunds");

            migrationBuilder.DropTable(
                name: "Trial");
        }
    }
}

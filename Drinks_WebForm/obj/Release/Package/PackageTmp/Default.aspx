<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Drinks_WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<script>
      function isNumberKey(evt)
      {
         var charCode = (evt.which) ? evt.which : evt.keyCode;
         if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;    
         return true;
      }
   </script>
<head runat="server">
    <title></title>
    <style>
        * {
  box-sizing: border-box;
}

body {
  font-family: Arial, Helvetica, sans-serif;
}

/* Style the header */
header {
  background-color: #facc7d;
  padding: 10px;
  text-align: center;
  font-size: 25px;
  color: white;
}

/* Create two columns/boxes that floats next to each other */
nav {
  float: left;
  width: 25%;
  height: 700px; /* only for demonstration, should be removed */
  background: #ccc;
  padding: 30px;
  padding-left:50px;
}

/* Style the list inside the menu */
nav ul {
  list-style-type: none;
  padding: 0;
            height: 696px;
        }

article {
  float: left;
  padding: 30px;
  width: 75%;
  background-color: #f1f1f1;
  height: 700px; /* only for demonstration, should be removed */
   padding-left:50px;
}

/* Clear floats after the columns */
section:after {
  content: "";
  display: table;
  clear: both;
}

/* Style the footer */
footer {
  background-color: #facc7d;
  padding: 30px;
  text-align: center;
  color: white;
}

/* Responsive layout - makes the two columns/boxes stack on top of each other instead of next to each other, on small screens */
@media (max-width: 600px) {
  nav, article {
    width: 100%;
    height: auto;
  }
}

#photos{
    padding-top:120px;
}

#caphe,tradao, matcha, coca{
    padding-left:100px;
}


    </style>
</head>
<body>
    <form id="form" runat="server">
            <header>
                <h3>MANAGEMENT OF DRINKS ON WEBFORM</h3>
            </header>

            <section>
                <nav>
                        <h3>Information:</h3>
                        <b>ID:</b><br />              
                        <asp:TextBox ID="txtID" runat="server" Width="265px"></asp:TextBox><br /><br />
                    
                        <b>Type:</b><br />                      
                        <asp:TextBox ID="txtType" runat="server" Width="265px"></asp:TextBox><br /><br />
                       
                        <b>Name:</b><br />
                        <asp:TextBox ID="txtName" runat="server" Width="265px"></asp:TextBox><br /><br />
                      
                        <b>Ingredients:</b><br />                        
                        <asp:TextBox ID="txtIngredients" runat="server" Width="265px"></asp:TextBox><br /><br />
                      
                        <b>Price:</b><br />                      
                        <asp:TextBox ID="txtPrice" runat="server" onkeypress="return isNumberKey(event)" Width="265px"></asp:TextBox><br />  <br />                            
                       
                        <h3>Function</h3>                       
                        <asp:Button ID="btnAdd" runat="server" Text="ADD" Height="38px" Width="80px" OnClick="btnAdd_Click" Font-Bold="True" BackColor="#3333FF" BorderColor="#3333FF" />&ensp;                          
                        <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Height="38px" Width="80px" OnClick="btnUpdate_Click" Font-Bold="True" BackColor="#FFCC00" BorderColor="#FFCC00" />&ensp;
                        <asp:Button ID="btnDelete" runat="server" Text="DELETE" Height="38px" Width="80px"
                            OnClientClick="return confirm('Are You Sure?');" OnClick="btnDelete_Click" Font-Bold="True" BackColor="#CC0000" BorderColor="#CC0000"/>&emsp;  <br /><br />
                        <asp:Label ID="lbdebug" runat="server"></asp:Label>

                </nav>
                <article>
                    <h1>Data:</h1>                    
                     <asp:TextBox ID="txtkeyword" runat="server" Height="20px" Width="492px"></asp:TextBox> &emsp;
                    <asp:Button ID="bntSearch" runat="server" Text="Search" Height="29px" Width="81px" OnClick="bntSearch_Click" Font-Bold="True" /><br /><br />
                    <asp:GridView ID="GridView" runat="server" OnSelectedIndexChanged="GridView_SelectedIndexChanged" AutoGenerateSelectButton="True"></asp:GridView>
                    
                    <h1 id="photos">Photos:</h1>
                    <a id="caphe">
                        <asp:image id="img" runat="server" imageurl="https://www.highlandscoffee.com.vn/vnt_upload/product/05_2018/CFD.png" Height="200px" Width="200px"/>
                    </a>

                     <a id="tradao">
                        <asp:image id="Image1" runat="server" imageurl="https://www.highlandscoffee.com.vn/vnt_upload/product/03_2018/TRATHANHDAO.png" Height="200px" Width="200px"/>
                    </a>

                    <a id="matcha">
                        <asp:image id="Image2" runat="server" imageurl="https://file.hstatic.net/1000044340/file/a-highlands-coffee-thuong-se-co-them-thach-tra-xanh-lam-topping-an-kem_4efdcc5a1c184a73af58ce2deceb736e_grande.png" Height="200px" Width="200px"/>
                    </a>

                     <a id="coca">
                        <asp:image id="Image3" runat="server" imageurl="https://product.hstatic.net/1000379753/product/coca_cola_b74a8f1c98e549babdac5369c20c0741_master.png" Height="200px" Width="200px"/>
                    </a>

                </article>
            </section>

            <footer>
                <div>Design By
                <a href="https://www.facebook.com/nguyen.the.luan1999">Nguyễn Luân</a></div>
            </footer>
    </form>
</body>
</html>

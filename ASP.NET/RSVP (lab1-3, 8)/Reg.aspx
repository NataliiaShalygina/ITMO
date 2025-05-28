<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reg.aspx.cs" Inherits="Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Приглашаем на семинар</h1> 
            <p></p>

            <div> 
                <label>Ваше имя:</label><asp:TextBox ID="name" 
                    runat="server"></asp:TextBox> 
            </div> 
            
            <div> 
                <label>Ваш email:</label><asp:TextBox ID="email" 
                    runat="server"></asp:TextBox> 
            </div> 
            
            <div> 
                <label>Ваш телефон:</label><asp:TextBox ID="phone" 
                    runat="server"></asp:TextBox> 
            </div> 
            
            <div> 
                <label>Вы будете делать доклад?</label><asp:CheckBox ID="CheckBoxYN" 
                    runat="server" /> 
            </div>

            <div> 
                Введите название доклада: 
                <asp:TextBox ID="TextBoxTitle" runat="server" Width="345px"></asp:TextBox>
            </div>

            <div> 
                Введите аннотацию доклада: 
                <asp:TextBox ID="TextBoxTextAnnot" runat="server" Width="345px"></asp:TextBox> 
            </div>

            <div> 
                Введите название доклада: 
                <asp:TextBox ID="TextBoxTitle2" runat="server" Width="345px"></asp:TextBox> 
            </div>

            <div> 
                Введите аннотацию доклада: 
                <asp:TextBox ID="TextBoxTextAnnot2" runat="server" Width="345px"></asp:TextBox> 
            </div>
            
            <div>
                <button type="submit">Отправить ответ на приглашение RSVP</button>
            </div>

        </div>
    </form>
</body>
</html>

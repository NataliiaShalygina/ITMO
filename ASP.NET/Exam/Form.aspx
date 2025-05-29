<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Exam.Form" MasterPageFile="~/Site.master"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    
<div>
    
    <div> 
        <label>Имя студента:</label><asp:TextBox ID="FirstName" 
        runat="server"></asp:TextBox> 
    </div>
    
    <div>
         <label>Фамилия студента:</label><asp:TextBox ID="LastName" 
             runat="server"></asp:TextBox>
     </div>
        
     <div>
          <label>Группа:</label><asp:TextBox ID="Group" 
              runat="server"></asp:TextBox>
     </div>
        
     <div>
            <label>Оценка по алгебре:</label><asp:TextBox ID="Algebra" 
                runat="server"></asp:TextBox>
     </div>
    
     <div>
            <label>Оценка по геометрии:</label><asp:TextBox ID="Geometry" 
                runat="server"></asp:TextBox>
     </div>
     
     <div>
            <label>Оценка по математическому анализу:</label><asp:TextBox ID="MathAnalysis" 
                runat="server"></asp:TextBox>
     </div>
     
     <div>
            <label>Оценка по теории вероятностей:</label><asp:TextBox ID="ProbTheory" 
                runat="server"></asp:TextBox>
     </div>
     
     <div>
            <label>Оценка по физике:</label><asp:TextBox ID="Phisics" 
                runat="server"></asp:TextBox>
    </div>
        
    <div>
            <button type="submit">Отправить данные студента</button>
    </div>

</div>
</asp:Content>

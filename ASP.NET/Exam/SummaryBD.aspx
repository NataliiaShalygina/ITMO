<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="Exam.SummaryBD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Список студентов</h2>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="Имя" ReadOnly="True" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="Фамилиия" ReadOnly="True" SortExpression="LastName" />
                <asp:BoundField DataField="Group" HeaderText="Группа" ReadOnly="True" SortExpression="Group" />
                <asp:BoundField DataField="Algebra" HeaderText="Алгебра" ReadOnly="True" SortExpression="Algebra" />
                <asp:BoundField DataField="Geometry" HeaderText="Геометрия" ReadOnly="True" SortExpression="Geometry" />
                <asp:BoundField DataField="MathAnalysis" HeaderText="Математический анализ" ReadOnly="True" SortExpression="MathAnalysis" />
                <asp:BoundField DataField="ProbTheory" HeaderText="Теория вероятностей" ReadOnly="True" SortExpression="ProbTheory" />
                <asp:BoundField DataField="Phisics" HeaderText="Физика" ReadOnly="True" SortExpression="Phisics" />
                <asp:BoundField DataField="SumBall" HeaderText="Суммарный балл" ReadOnly="True" SortExpression="SumBall" />
                <asp:BoundField DataField="SrBall" HeaderText="Средний балл" ReadOnly="True" SortExpression="SrBall" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Exam.SampleContext" EntityTypeName="" Select="new (FirstName, LastName, Group, Algebra, Geometry, MathAnalysis, ProbTheory, Phisics, SumBall, SrBall)" TableName="StudentRecords">
        </asp:LinqDataSource>
    </form>
</body>
</html>

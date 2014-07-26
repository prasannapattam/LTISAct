<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LTContacts.aspx.cs" Inherits="LTISAct.LTContacts"  MasterPageFile="~/MasterPages/ListViewMasterPage.master" Trace="false" EnableViewState="true" %>

<asp:Content ID="headerContent" ContentPlaceHolderID="headerContentPlaceHolder" Runat="Server">
    <link href="/LTIS/content/toastr.css" rel="stylesheet"/>
</asp:content>
<asp:Content ID="toolbarContent" ContentPlaceHolderID="toolBarPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="viewContent" ContentPlaceHolderID="viewPlaceHolder" Runat="Server">		
<div id="divLoading" style="margin: 0px; padding: 0px; position: fixed; right: 0px;
    top: 0px; width: 100%; height: 100%; background-color: #666666; z-index: 30001;
    opacity: .8; filter: alpha(opacity=70);display:block">
    <p style="position: absolute; top: 30%; left: 45%; color: White;">
        please wait<br /><img src="/LTIS/Content/BlueOpal/loading-image.gif">
    </p>
</div>
    <h3>WEB INQURIES</h3>
    <div id="LTContacts" style="overflow: auto">
        
    </div>
</asp:Content>
<asp:Content ID="afterFormScriptContent" ContentPlaceHolderID="afterFormScriptContent" runat="server">
    <script src="/LTIS/scripts/toastr.js"></script>
    <script src="/LTIS/scripts/app-act.js"></script>
    <script language="javascript">
        $(function () {
            $("#LTContacts").load("/LTIS/Home/Act", function () {
                $("#LTContacts").width($("#LTContacts").parent().width() - 50);
                $("#LTContacts").height($("#LTContacts").parent().height() - 50);
                $("#divLoading").hide();
            });
        });

    </script>
   
</asp:Content>

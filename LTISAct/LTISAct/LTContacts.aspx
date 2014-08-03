<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LTContacts.aspx.cs" Inherits="LTISAct.LTContacts"  MasterPageFile="~/MasterPages/ListViewMasterPage.master" Trace="false" EnableViewState="true" %>

<asp:Content ID="headerContent" ContentPlaceHolderID="headerContentPlaceHolder" Runat="Server">
</asp:content>
<asp:Content ID="toolbarContent" ContentPlaceHolderID="toolBarPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="viewContent" ContentPlaceHolderID="viewPlaceHolder" Runat="Server">		
    <h3>WEB INQURIES</h3>
    <div id="LTContacts" style="overflow: auto">
        <div id="divLTContactLoading" style="margin: 0px; padding: 0px; right: 0px;
            top: 0px; width: 100%; height: 100%; background-color: #666666; z-index: 30001;
            opacity: .8; filter: alpha(opacity=70);display:block">
            <p style="position: absolute; top: 30%; left: 45%; color: White;">
                please wait<br /><img src="/LTIS/Content/BlueOpal/loading-image.gif">
            </p>
        </div>
    </div>
</asp:Content>
<asp:Content ID="afterFormScriptContent" ContentPlaceHolderID="afterFormScriptContent" runat="server">
    <script language="javascript">
        $(function () {
            $("#LTContacts").load("/LTIS/Home/Act", function () {
                $("#LTContacts").width($("#LTContacts").parent().width() - 5);
                $("#LTContacts").height($("#LTContacts").parent().height() - 5);
                //$("#divLoading").hide();
            });
        });

    </script>
   
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PersonalityDecoderApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="display: flex; justify-content: center; align-items: center; margin-top: 60px;">

        <div style="width: 420px; padding: 30px; border-radius: 20px; background: #fffaf3; box-shadow: 0 10px 25px rgba(0,0,0,0.08); text-align: center;">

            <h2 style="color: #8b5e3c; margin-bottom: 20px;">Decode Your Personality
            </h2>

            <!-- Name -->
            <asp:TextBox ID="txtName" runat="server"
                placeholder="Enter your name"
                Width="100%" Height="38px"
                Style="border-radius: 8px; border: 1px solid #d6c7b0; padding: 6px; outline: none;">
            </asp:TextBox>

            <asp:RequiredFieldValidator
                ID="rfvName"
                runat="server"
                ControlToValidate="txtName"
                ErrorMessage="Please enter your name"
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="vg1">
            </asp:RequiredFieldValidator>

            <br />
            <br />

            <!-- Rashi Dropdown -->
            <asp:DropDownList ID="ddlRashi" runat="server"
                Width="100%" Height="40px"
                Style="border-radius: 8px; border: 1px solid #d6c7b0; padding: 5px; background: white; cursor: pointer;">

                <asp:ListItem Text="Select Rashi" Value="" />

                <asp:ListItem Text="Aries (A, L, E)" Value="Aries" />
                <asp:ListItem Text="Taurus (B, V, U)" Value="Taurus" />
                <asp:ListItem Text="Gemini (K, C, G)" Value="Gemini" />
                <asp:ListItem Text="Cancer (D, H)" Value="Cancer" />
                <asp:ListItem Text="Leo (M, T)" Value="Leo" />
                <asp:ListItem Text="Virgo (P, Th, N)" Value="Virgo" />
                <asp:ListItem Text="Libra (R, T)" Value="Libra" />
                <asp:ListItem Text="Scorpio (N, Y)" Value="Scorpio" />
                <asp:ListItem Text="Sagittarius (Bh, Dh, Ph)" Value="Sagittarius" />
                <asp:ListItem Text="Capricorn (Kh, J)" Value="Capricorn" />
                <asp:ListItem Text="Aquarius (G, S, Sh)" Value="Aquarius" />
                <asp:ListItem Text="Pisces (D, Ch, Z)" Value="Pisces" />

            </asp:DropDownList>

            <asp:RequiredFieldValidator
                ID="rfvRashi"
                runat="server"
                ControlToValidate="ddlRashi"
                InitialValue=""
                ErrorMessage="Please select a rashi"
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="vg1">
            </asp:RequiredFieldValidator>
            <br />
            <br />

            <!-- Button -->
            <asp:Button ID="btnReveal" runat="server"
                Text="Reveal Personality"
                OnClick="btnReveal_Click"
                OnClientClick="return showLoaderAndDelay();"
                ValidationGroup="vg1"
                Style="background: #8b5e3c; color: white; border: none; padding: 12px; border-radius: 10px; width: 100%; font-weight: 600; cursor: pointer;"></asp:Button>

            <br />
            <br />

            <asp:Label ID="lblLoading" runat="server"
                Text="⏳ Analyzing your personality..."
                Style="display: none; color: #8b5e3c; font-weight: 600;">
            </asp:Label>

            <!-- Result -->
            <asp:Label ID="lblResult" runat="server"
                Style="display: block; margin-top: 15px; padding: 20px; border-radius: 15px; background: #f1e8da; color: #4a3b2c; font-size: 14px; line-height: 1.6; box-shadow: inset 0 2px 5px rgba(0,0,0,0.05);">
            </asp:Label>


        </div>

    </div>


    <script>
        function showLoaderAndDelay() {

            if (typeof (Page_ClientValidate) == 'function') {
                if (!Page_ClientValidate('vg1')) {
                    return false; // stop if validation fails
                }
            }

            var loader = document.getElementById('<%= lblLoading.ClientID %>');
        loader.style.display = 'block';

        var btn = document.getElementById('<%= btnReveal.ClientID %>');
        btn.disabled = true;

        setTimeout(function () {
            __doPostBack('<%= btnReveal.UniqueID %>', '');
        }, 1200);

            return false;
        }
    </script>

</asp:Content>

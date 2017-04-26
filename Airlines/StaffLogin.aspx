<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <div class="container">
    	<div class="row">
            <br /><br /><br />
			<div class="col-md-6 col-md-offset-3">
				<div class="panel panel-login">
					<div class="panel-heading">
						<div class="row">
							<div class="col-xs-12">
								<h3>Login</h3>
							</div>
							
						</div>
						<hr>
					</div>
					<div class="panel-body">
						<div class="row">
                            <asp:Label ID="msg" runat="server"></asp:Label>
							<div class="col-lg-12">
								<form id="login-form" action="LoginProcess.aspx" method="post" role="form" style="display: block;">
									<div class="form-group">
										<input runat="server" type="text" name="username" id="username" tabindex="1" class="form-control" placeholder="Username" value="">
									</div>
                                    <div>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Email" ControlToValidate="username"></asp:RequiredFieldValidator>

                                    </div>
									<div class="form-group">
										<input runat="server" type="password" name="password" id="password" tabindex="2" class="form-control" placeholder="Password">
									</div>
                                    <div>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Password" ControlToValidate="password"></asp:RequiredFieldValidator>

                                    </div>
									<div class="form-group">
										<div class="row">
											<div class="col-sm-6 col-sm-offset-3">
												<asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-default" OnClick="btnLogin_Click"/>
											</div>
										</div>
									</div>
								</form>
								
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>

</asp:Content>

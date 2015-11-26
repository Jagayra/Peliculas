<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="cs/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="cs/bootstrap-datetimepocker.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: chocolate">
    <div class="container">
        <div class="col-md-1">
        </div>
        <div class="col-md-10">
            <div class="panel-body" style="background-color: Black">
                <div class="row">
                    <div class="tab-content">
                        <div class="text-right">
                            <br />
                            <a class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">Registrar</a>
                            <a class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal2">Login</a>
                            <br />
                            <br />
                        </div>
                        <div class="col-md-6">
                            <div id="carousel1" class="carousel slide" data-ride="carousel">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <asp:PlaceHolder ID="phCarrusel" runat="server" />
                                </ol>
                                <!-- Wrapper for slides -->
                                <div class="carousel-inner" role="listbox">
                                    <asp:PlaceHolder ID="phCarrusel1" runat="server" />
                                </div>
                                <!-- Controls -->
                                <a class="left carousel-control" href="#carousel1" role="button" data-slide="prev"><span
                                    class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                                        Previous</span> </a><a class="right carousel-control" href="#carousel1" role="button"
                                            data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                                            </span><span class="sr-only">Next</span> </a>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div id="carousel2" class="carousel slide" data-ride="carousel">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <li data-target="#carousel2" data-slide-to="0" class="active"></li>
                                    <li data-target="#carousel2" data-slide-to="1"></li>
                                    <li data-target="#carousel2" data-slide-to="2"></li>
                                </ol>
                                <!-- Wrapper for slides -->
                                <div class="carousel-inner" role="listbox">
                                    <div class="item active">
                                        <img src="img/sinsajo-juegos-hambre-jennifer-lawrence-trailer-poster.jpg" style="height: 200px"
                                            width="400px" />
                                        <span class="style1"><strong>JUEGOS DEL HAMBRE</strong></span>
                                        <div class="carousel-caption">
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="img/maxresdefault.jpg" style="height: 200px" width="400px" />
                                        <span class="style1"><strong>AVENGERS</strong></span>
                                        <div class="carousel-caption">
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="img/fauno-cartel.jpg" style="height: 200px" width="400px" />
                                        <span class="style1"><strong>EL LABERINTO DE FAUNO</strong></span>
                                        <div class="carousel-caption">
                                        </div>
                                    </div>
                                </div>
                                <!-- Controls -->
                                <a class="left carousel-control" href="#carousel2" role="button" data-slide="prev"><span
                                    class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                                        Previous</span> </a><a class="right carousel-control" href="#carousel2" role="button"
                                            data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                                            </span><span class="sr-only">Next</span> </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" placeholder="Nombre de la pelicula" />
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker1'>
                                <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaLanzamiento" />
                                <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlGenero">
                            <asp:ListItem Text="[Elige el genero]" Value="-1" />
                        </asp:DropDownList>
                    </div>
                    <br />
                    <div class="col-md-6">
                        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlClasificacion">
                            <asp:ListItem Text="Elige la Clasificacion" Value="-1" />
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <%-- <li class="lfield">
                            <input id="story" name="story" value="BUSCAR PELICULA ..." onblur="if(this.value=='') this.value='BUSCAR PELICULA ...';"
                                onfocus="if(this.value=='BUSCAR PELICULA ...') this.value='';" type="text" autocomplete="off">
                        </li>--%>
                        <asp:ImageButton ID="imbBuscar" ImageUrl="img/boton-buscar.jpg" runat="server" Width="150px" />
                    </div>
                </div>
                <br />
                <%--<div class="row">
                    <div class="col-md-4">
                        <asp:Image ID="ImgPelicula1" ImageUrl="img/Amor_a_primera_visa-381772697-large.jpg"
                            runat="server" Width="200px" />
                    </div>
                    <div class="col-md-4">
                        <asp:Image ID="ImgPelicula2" ImageUrl="img/Hombres_de_honor-584186623-large.jpg"
                            runat="server" Width="200px" />
                    </div>
                    <div class="col-md-4">
                        <asp:Image ID="ImgPelicula3" ImageUrl="img/IMG1.JPG" runat="server" Width="200px" />
                    </div>
                </div>--%>
                <%--<br />--%>
                <%--<div class="row">
                    <div class="col-md-4">
                        <asp:Image ID="imgPelicula4" ImageUrl="img/1548--400-Diario_de_una_pasion__grande_.JPG"
                            runat="server" Width="200px" />
                    </div>
                    <div class="col-md-4">
                        <asp:Image ID="Image1" ImageUrl="img/266%20-%20Las%20Crónicas%20de%20Spiderwick%20-%202008%20(1).jpg"
                            runat="server" Width="200px" />
                    </div>
                    <div class="col-md-4">
                        <asp:Image ID="Image2" ImageUrl="img/donde-crecen-los-suenos_70018461.jpg" runat="server"
                            Width="200px" />
                    </div>
                </div>--%>
                <div class="row" style="margin-top: 20px;">
                    <asp:PlaceHolder runat="server" ID="phPeliculas" />
                </div>
            </div>
        </div>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">
                        Inicia Registro
                    </h4>
                </div>
                <div class="modal-body">
                    <div>
                        <asp:Label Text="Login" runat="server" ID="lbllogin" />
                        <br />
                        <input type="text" name="login_name" id="login" />
                    </div>
                    <asp:Label Text="Password" runat="server" ID="lblPassword" />
                    <br />
                    <input type="text" name="password" id="password" />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        Close</button>
                    <asp:Button Text="Entrar" ID="btnEntrar" runat="server" class="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="myModal2" tabindex="-1" role="dialog" aria-labelledby="myModalLabel2">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel2">
                        Iniciar Sesion
                    </h4>
                </div>
                <div class="modal-body">
                    <div>
                        <asp:Label Text="Login" runat="server" ID="Label1" />
                        <br />
                        <input type="text" name="login_name" id="Text1" />
                    </div>
                    <asp:Label Text="Password" runat="server" ID="Label2" />
                    <br />
                    <input type="text" name="password" id="Text2" />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        Close</button>
                    <asp:Button Text="Entrar" ID="Button1" runat="server" class="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
    </form>
    <script src="js/jquery-2.1.4.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <script src="js/moment.js" type="text/javascript"></script>
    <script src="js/bootstrap-datetimepicker.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#datetimepicker1').datetimepicker({
                viewMode: 'years',
                format: 'MM/YYYY',
                locale: 'es'
            });
        });
    </script>
</body>
</html>

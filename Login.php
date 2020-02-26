<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login / Sign Up</title>
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

    <!-- Font Awesome///////// -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <style type="text/css">
        #loginCard{
            position: absolute;
            top:15%;
            margin-bottom: 2%;
        }
    </style>
</head>
<?php
    session_start();
    if(isset($_SESSION["user"]))
        header("Location: Home.php");
?>
<body>
    <div class="container-fluid" id="loginCard">
        <div class="row justify-content-center">
            <div style="width: 400px;">
                <div class="card"
                    style="background: linear-gradient(115deg, #17cccc,#17cccc 50%, #17aaaa, #17aaaa 50%); border-radius: 15px;">
                    <div class="card-header text-center">
                        <b>Login / Sign Up</b>
                    </div>
                    <div class="card-body bg-light">
                        <div id="su" style="display: none;">
                            <form id="suForm">
                                <div class="form-group">
                                    <i class="fa fa-user fa-2x mr-1"></i>
                                    <label for="nam">Name:</label>
                                    <input type="text" class="form-control" placeholder="Enter Name" id="nam">
                                </div>
                                <div class="form-group">
                                    <i class="fa fa-envelope fa-lg mr-1"></i>
                                    <label for="lgn">Login:</label>
                                    <input type="email" class="form-control" placeholder="Enter Login" id="lgn">
                                </div>
                                <div class="form-group">
                                    <i class="fa fa-lock fa-2x mr-1"></i>
                                    <label for="pass">Password:</label>
                                    <input type="password" class="form-control" placeholder="Enter Password" id="pass">
                                </div>
                                <div class="form-group">
                                    <i class="fa fa-lock fa-2x mr-1"></i>
                                    <label for="confirmPass">Confirm Password:</label>
                                    <input type="password" class="form-control" placeholder="Re-Enter Password"
                                        id="confirmPass">
                                </div>
                            </form>
                        </div>
                        <div id="lg">
                            <form id="lgForm">
                                <div class="form-group">
                                    <i class="fa fa-user fa-2x mr-1"></i>
                                    <label for="lLgn">Login:</label>
                                    <input type="text" class="form-control" placeholder="Enter Login" id="lLgn" autofocus>
                                </div>
                                <div class="form-group">
                                    <i class="fa fa-lock fa-2x mr-1"></i>
                                    <label for="lPass">Password:</label>
                                    <input type="password" class="form-control" placeholder="Enter Password" id="lPass">
                                </div>
                            </form>
                        </div>
                        <div id="errMsg" class="text-danger"></div>
                    </div>
                    <div class="card-footer text-center">
                        <div><button id="lgBtn" class="btn btn-light mb-1" type="submit" form="lgForm">Login</button></div>
                        <div id="message">Not a member?
                            <span onclick="displaySignUp(1)" class="text-light" style="cursor: pointer;">Sign Up
                                here!</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

	<script>
		function displaySignUp(temp){
			if(temp){
                $("#lLgn").val("");
                $("#errMsg").text("");
                $("#lPass").val("");
				$("#su").slideToggle(700);
				$("#lg").slideToggle(700);
				$("#lgBtn").text("Sign Up");
                $("#lgBtn").attr("form", "suForm");
				$("#message").html("Login<span onclick='displaySignUp(0)' class='text-light' style='cursor: pointer;'> here!</span></div>");
			}
			else{
                $("#lgn").val("");
                $("#pass").val("");
                $("#nam").val("");
                $("#confirmPass").val("");
                $("#errMsg").text("");
				$("#su").slideToggle(700);
				$("#lg").slideToggle(700);
				$("#lgBtn").text("Login");
                $("#lgBtn").attr("form", "lgForm");
				$("#message").html("Not a member? <span onclick='displaySignUp(1)' class='text-light' style='cursor: pointer;'>Sign Up here!</span></div>");
			}
		}
		
		$("#lgBtn").click(function(){
            if($("#lgBtn").attr("form") == "lgForm"){
                let lgn = $("#lLgn").val();
                let pass = $("#lPass").val();
                if(lgn != "" && pass != ""){
                    $.post("DB_API.php", "login="+lgn+"&pass="+pass+"&action=validate", function(data, status){
                        if(data != "Error"){
                            window.location.href="Home.php";
                        }
                        else{
                            $("#errMsg").text("Error!! Invalid Login or Password!");
                            $("#lPass").val("");
                        }
                    });
                }
                else{
                    $("#errMsg").text("Error!! Please fill out all the Fields!");
                }
            }
            else{
                let lgn = $("#lgn").val();
                let pass = $("#pass").val();
                let name = $("#nam").val();
                let cPass = $("#confirmPass").val();
                if(lgn != "" && pass != "" && cPass != "" && name != ""){
                    $.post("DB_API.php", "login="+lgn+"&pass="+pass+"&name="+name+"&action=signUp", function(data, status){
                        if(data != "Error"){
                            $("#lgn").val("");
                            $("#pass").val("");
                            $("#nam").val("");
                            $("#confirmPass").val("");
                            $("#errMsg").html("<span class='text-success'>User added Successfully!!</span>");
                        }
                        else{
                            $("#lgn").val("");
                            $("#errMsg").text("Error!! Login already exists!");
                        }
                    });
                }
                else{
                    $("#errMsg").text("Error!! Please fill out all the Fields!");
                }
            }
            return false;
        });

        $("#nam, #lgn, #pass, #confirmPass, #lPass, #lLgn").on("input", function(){
            $("#errMsg").text("");
        });
	</script>
	
</body>
</html>
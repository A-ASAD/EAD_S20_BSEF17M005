<!DOCTYPE html>
<html>

<head>
    <title>Home</title>
    <!-- Font Awesome-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.1/css/all.min.css" />
    <!-- bootstrap /////////-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <style>
        .selected {
            color: white;
            background-color: #267aff;
        }
        .selected i {
            color: white !important;
        }
        .folder {
            border: 2px solid black;
            width: 150px;
            cursor: pointer;
            overflow: hidden;
            white-space: nowrap;
            text-overflow: ellipsis;
        }
    </style>
</head>
<?php
session_start();
if (!$_SESSION["user"])
    header("Location: Login.php");
if (isset($_REQUEST["Logout"])) {
    session_destroy();
    header("Location: Login.php");
}
    $pwd = 0;
    if(isset($_REQUEST["id"]))
        $pwd=$_REQUEST["id"];
?>

<body>
    <div class="container-fluid">
        <div class="float-right mt-1">
            <form><input type="submit" name="Logout" value="Logout" class="btn btn-danger"></form>
        </div>
        <div><button id="modalBtn" class="btn btn-success mt-1" data-toggle="modal" data-target="#nF"><b>+</b> New Folder</button></div>
        <div id="main">

        </div>
    </div>

    <div class="modal fade" id="nF"> <!--Modal for creating new folder name-->
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">New Folder</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <form id="frm">
                        <div class="form-group">
                            <label for="fName">Name: </label>
                            <input class="form-control" type="text" id="fName">
                        </div>
                    </form>
                    <div id="errMsg" class="text-danger"></div>
                </div>
                <div class="modal-footer justify-content-center">
                    <input type="submit" form="frm" value="Create Folder" class="btn btn-success" id="newFolder">
                </div>
            </div>
        </div>
    </div>

    <script>
        $(function(){
            <?php if($pwd){?>
                $.post("DB_API.php", "parent="+<?php echo $pwd;?>+"&action=getFolders", function(data, status) {
            <?php }else{?>
                $.post("DB_API.php", "parent=0&action=getFolders", function(data, status) {  //For loading folders at startup
                <?php } ?>
                if (data != "Error") {
                    let result = JSON.parse(data);
                    for (let folder in result) {
                        let fldr = $("<div>");
                        fldr.html("<i class='fa fa-folder-open fa-2x text-secondary mr-1'></i>" + result[folder][1]);
                        fldr.attr({
                            "class": "mt-3 ml-3 rounded-lg px-2 folder",
                            "onclick": "clickHandler(" + result[folder][0] + ")",
                            "id": result[folder][0],
                            "title": result[folder][1]
                        });
                        $("#main").append(fldr);
                    }
                } else
                    $("#main").html("<div class='text-center pt-4'><b>Folder is Empty!</b></div>");
            });

            $("#newFolder").click(function(){ //To Add a new Folder
                let folderName=$("#fName").val();
                if(folderName != ""){
                    $.post("DB_API.php", "parent="+<?php echo $pwd;?>+"&name="+folderName+"&action=addFolder", function(data, status) {
                    if (data != "Error"){
                        $("#errMsg").html("<span class='text-success'>Folder Created!</span>");
                        if($("#main div b").length)
                            $("#main").html("");
                        let fldr = $("<div>");
                        fldr.html("<i class='fa fa-folder-open fa-2x text-secondary mr-1'></i>" + folderName);
                        fldr.attr({
                            "class": "mt-3 ml-3 rounded-lg px-2 folder",
                            "onclick": "clickHandler(" + data + ")",
                            "id": data
                        });
                        $("#main").append(fldr);
                        $("#fName").val("");
                    }
                    else
                        $("#errMsg").text("Folder Already Esixts!");
                    });
                }
                else
                $("#errMsg").text("Invalid Folder Name Entered!");
                return false;
            });

            $("#modalBtn").click(function(){
                $("#fName").val("");
                $("#errMsg").text("");
            });
        });
        let clicks = 0; // controlling click & dbclick events
        function clickHandler(id) {
            clicks++;
            if (clicks == 1) {
                setTimeout(function() {
                    if (clicks == 1) {
                        if ($("#" + id).hasClass("selected"))
                            $("#" + id).toggleClass("selected");
                        else {
                            let folders = $("#main > div");
                            for (let i = 0; i < folders.length; i++) {
                                folders[i].classList.remove("selected");
                            }
                            $("#" + id).toggleClass("selected");
                        }
                    } else {
                        window.location.href = "Home.php?id=" + id;
                    }
                    clicks = 0;
                }, 100);
            }
        }
    </script>
</body>
</html>
<?php
    $conn = mysqli_connect("localhost", "root", "", "mydb");  //DB Connection
    if(!$conn)
        die("Error:".mysqli_connect_error());

    if($_REQUEST["action"] == "addFolder"){        //Add Folder
        $query = "insert into folder(folderName, parentFolderId) select '".$_REQUEST["name"]."', ".$_REQUEST["parent"].
        " where ( select folderName from folder where lower(folderName) = lower('".$_REQUEST["name"]."') and parentFolderId = '".$_REQUEST["parent"]."') is null";
        $result = mysqli_query($conn, $query);
        if(mysqli_affected_rows($conn))
            echo mysqli_insert_id($conn);
        else
            echo "Error";
    }
    else if($_REQUEST["action"] == "getFolders"){           // Get Folders
        $query = "select folderId,folderName from folder where parentFolderId = ".$_REQUEST["parent"];
        $result = mysqli_query($conn, $query);
        if(mysqli_num_rows($result)){
            $result = mysqli_fetch_all($result);
            echo json_encode($result);
        }
        else
            echo "Error";
    }
    else if($_REQUEST["action"] == "validate"){          //Validate User
        session_start();
        $query = "select name from user where login = '".$_REQUEST["login"]."' and password = '".$_REQUEST["pass"]."'";
        $result = mysqli_query($conn, $query);
        if(mysqli_num_rows($result)){
            $result = mysqli_fetch_assoc($result);
            $_SESSION["user"] = $result["name"];
            echo "Success";
        }
        else
            echo "Error";
    }
    else if($_REQUEST["action"] == "signUp"){           //Sign Up
        session_start();
        $query = "insert into user select '".$_REQUEST["login"]."','".$_REQUEST["pass"]."','".$_REQUEST["name"].
        "' where (select login from user where lower(login) = lower('".$_REQUEST["login"]."')) is null";
        $result = mysqli_query($conn, $query);
        if(mysqli_affected_rows($conn))
            echo "Success";
        else
            echo "Error";
    }
    else
        echo "Error";
?>
<?php

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "cwp1_231";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection Fialed". $conn->connect_error);
}?>


<?php

session_unset();
var_dump($_SESSION);
header("location: index.html");

?>
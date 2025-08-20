<?php
$index = isset($_GET['index']) ? intval($_GET['index']) : 0;
$submissions = json_decode(file_get_contents("data.json"), true);

if (isset($submissions[$index])) {
    echo json_encode($submissions[$index]);
} else {
    http_response_code(404);
    echo json_encode(["status" => "error", "message" => "Submission not found"]);
}
?>
<?php
$index = isset($_GET['index']) ? intval($_GET['index']) : -1;
$data = json_decode(file_get_contents("php://input"), true);
$submissions = json_decode(file_get_contents("data.json"), true);

if ($index >= 0 && isset($submissions[$index]) && $data) {
    $submissions[$index] = $data;
    file_put_contents("data.json", json_encode($submissions, JSON_PRETTY_PRINT));
    echo json_encode(["status" => "success", "message" => "Submission updated"]);
} else {
    http_response_code(400);
    echo json_encode(["status" => "error", "message" => "Invalid update"]);
}
?>
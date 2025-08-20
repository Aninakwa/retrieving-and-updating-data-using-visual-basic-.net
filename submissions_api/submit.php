<?php
$data = json_decode(file_get_contents("php://input"), true);

if ($data) {
    $all = file_get_contents("data.json");
    $submissions = $all ? json_decode($all, true) : [];
    $submissions[] = $data;

    file_put_contents("data.json", json_encode($submissions, JSON_PRETTY_PRINT));
    echo json_encode(["status" => "success", "message" => "Submission saved"]);
} else {
    http_response_code(400);
    echo json_encode(["status" => "error", "message" => "Invalid data"]);
}
?>
<?php
$index = isset($_GET['index']) ? intval($_GET['index']) : -1;
$submissions = json_decode(file_get_contents("data.json"), true);

if ($index >= 0 && isset($submissions[$index])) {
    array_splice($submissions, $index, 1);
    file_put_contents("data.json", json_encode($submissions, JSON_PRETTY_PRINT));
    echo json_encode(["status" => "success", "message" => "Submission deleted"]);
} else {
    http_response_code(400);
    echo json_encode(["status" => "error", "message" => "Invalid index"]);
}
?>
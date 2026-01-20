body {
    font-family: Arial, sans-serif;
    background: #f2f4f8;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.chat-container {
    width: 380px;
    background: white;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0,0,0,0.2);
    display: flex;
    flex-direction: column;
}

.chat-header {
    background: #4a6cf7;
    color: white;
    padding: 15px;
    text-align: center;
    font-size: 18px;
    border-radius: 10px 10px 0 0;
}

.chat-box {
    padding: 10px;
    height: 300px;
    overflow-y: auto;
}

.bot-message, .user-message {
    margin: 8px 0;
    padding: 10px;
    border-radius: 8px;
    max-width: 80%;
}

.bot-message {
    background: #e4e8ff;
    align-self: flex-start;
}

.user-message {
    background: #4a6cf7;
    color: white;
    align-self: flex-end;
    margin-left: auto;
}

.buttons {
    display: flex;
    justify-content: space-around;
    padding: 10px;
}

.buttons button {
    padding: 8px;
    border: none;
    background: #4a6cf7;
    color: white;
    border-radius: 5px;
    cursor: pointer;
}

.input-area {
    display: flex;
    padding: 10px;
    border-top: 1px solid #ddd;
}

.input-area input {
    flex: 1;
    padding: 8px;
    border-radius: 5px;
    border: 1px solid #ccc;
}

.input-area button {
    margin-left: 5px;
    padding: 8px 12px;
    background: #4a6cf7;
    color: white;
    border: none;
    border-radius: 5px;
}

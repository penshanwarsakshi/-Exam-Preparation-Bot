const chatBox = document.getElementById("chatBox");

function addMessage(message, type) {
    const div = document.createElement("div");
    div.className = type;
    div.innerText = message;
    chatBox.appendChild(div);
    chatBox.scrollTop = chatBox.scrollHeight;
}

function sendMessage() {
    const input = document.getElementById("userInput");
    const text = input.value.trim();

    if (text === "") return;

    addMessage(text, "user-message");
    input.value = "";

    setTimeout(() => {
        botReply(text);
    }, 500);
}

function botReply(text) {
    let response = "I can help with study plans, MCQs, and exam tips 📘";

    if (text.toLowerCase().includes("ohm")) {
        response = "Ohm’s Law: V = I × R\nWhere V = Voltage, I = Current, R = Resistance.";
    } else if (text.toLowerCase().includes("time table")) {
        response = "Study 2–3 hours daily, revise weekly, and take mock tests every Sunday.";
    }

    addMessage(response, "bot-message");
}

function studyPlan() {
    addMessage("📅 7-Day Study Plan:\nDay 1–2: Basics\nDay 3–4: Practice\nDay 5: Revision\nDay 6: Mock Test\nDay 7: Analysis", "bot-message");
}

function mcq() {
    addMessage(
        "📝 MCQ:\nWhat is the SI unit of force?\nA) Joule\nB) Newton\nC) Pascal\nD) Watt\n\nAnswer: B) Newton",
        "bot-message"
    );
}

function motivation() {
    addMessage("💡 Stay consistent! Small daily progress leads to big success 🚀", "bot-message");
}

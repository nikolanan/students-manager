/**
 * ChatMessage — renders a single user or assistant bubble.
 * Matches the existing soge-* design system.
 */
function ChatMessage({ role, content, isLatest }) {
    const isAssistant = role === 'assistant';

    return (
        <div
            className={`chatbot-message chatbot-message--${role}${isLatest ? ' chatbot-message--latest' : ''}`}
            aria-label={isAssistant ? 'Съобщение от асистента' : 'Твоето съобщение'}
        >
            {/* Avatar dot */}
            <div className="chatbot-message__avatar" aria-hidden="true">
                {isAssistant ? '🤖' : '👤'}
            </div>

            {/* Bubble */}
            <div className="chatbot-message__bubble">
                {/* Render content with basic newline support */}
                {content.split('\n').map((line, i) => (
                    line.trim() === ''
                        ? <br key={i} />
                        : <p key={i} className="chatbot-message__text">{line}</p>
                ))}
            </div>
        </div>
    );
}

export default ChatMessage;

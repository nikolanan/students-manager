import PropTypes from 'prop-types';

function ChatMessage({ role, content, isLatest }) {
    const isAssistant = role === 'assistant';

    return (
        <div
            className={`chatbot-message chatbot-message--${role}${isLatest ? ' chatbot-message--latest' : ''}`}
            aria-label={isAssistant ? 'Съобщение от асистента' : 'Твоето съобщение'}
        >
            {/* Avatar */}
            <div className="chatbot-message__avatar" aria-hidden="true">
                {isAssistant ? '🤖' : '👤'}
            </div>

            {/* Bubble */}
            <div className="chatbot-message__bubble">
                {content.split('\n').map((line, i) =>
                    line.trim() === ''
                        ? <br key={`br-${role}-${i}`} />
                        : <p key={`line-${role}-${i}-${line.slice(0, 8)}`} className="chatbot-message__text">{line}</p>
                )}
            </div>
        </div>
    );
}

ChatMessage.propTypes = {
    role: PropTypes.string.isRequired,
    content: PropTypes.string.isRequired,
    isLatest: PropTypes.bool,
};

ChatMessage.defaultProps = {
    isLatest: false,
};

export default ChatMessage;

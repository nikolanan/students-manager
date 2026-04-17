import { useChatbot } from './useChatbot';
import ChatMessage from './ChatMessage';
import ChatInput from './ChatInput';
import { useAuth } from '../../context/AuthContext';
import { Link } from 'react-router-dom';

function Chatbot() {
    const { isLoggedIn } = useAuth();
    const {
        messages,
        inputValue,
        setInputValue,
        isLoading,
        error,
        sessionSaved,
        examinationContext,
        messagesEndRef,
        inputRef,
        sendMessage,
        handleKeyDown,
        resetChat,
    } = useChatbot();

    return (
        <div className="soge-young-chatbot chatbot-container">

            {/* ── Context banner (shown when prior exam answers are loaded) ── */}
            {examinationContext && (
                <div className="chatbot-context-banner" role="status">
                    <span className="chatbot-context-icon" aria-hidden="true">📋</span>
                    <span>
                        Заредени са твоите предишни отговори от изпита —
                        AI асистентът може да ги използва като контекст.
                    </span>
                </div>
            )}

            {/* ── Guest notice ── */}
            {!isLoggedIn && (
                <div className="chatbot-guest-notice" role="alert">
                    <span>
                        Влез в профила си, за да се съхраняват разговорите ти.{' '}
                        <Link to="/login" className="chatbot-guest-link">Вход</Link>
                    </span>
                </div>
            )}

            {/* ── Messages area ── */}
            <div
                className="chatbot-messages"
                role="log"
                aria-label="Разговор с AI асистент"
                aria-live="polite"
            >
                {messages.map((msg, idx) => (
                    <ChatMessage
                        key={idx}
                        role={msg.role}
                        content={msg.content}
                        isLatest={idx === messages.length - 1}
                    />
                ))}

                {/* Typing indicator */}
                {isLoading && (
                    <div className="chatbot-typing" aria-label="Асистентът пише...">
                        <span className="chatbot-typing__dot" />
                        <span className="chatbot-typing__dot" />
                        <span className="chatbot-typing__dot" />
                    </div>
                )}

                {/* Error message */}
                {error && (
                    <div className="chatbot-error" role="alert">
                        <span className="chatbot-error__icon" aria-hidden="true">⚠️</span>
                        {error}
                    </div>
                )}

                {/* Saved indicator */}
                {sessionSaved && !isLoading && (
                    <div className="chatbot-saved" role="status" aria-live="polite">
                        ✓ Разговорът е записан
                    </div>
                )}

                <div ref={messagesEndRef} />
            </div>

            {/* ── Input area ── */}
            <ChatInput
                value={inputValue}
                onChange={setInputValue}
                onSend={sendMessage}
                onKeyDown={handleKeyDown}
                isLoading={isLoading}
                inputRef={inputRef}
            />

            {/* ── Footer actions ── */}
            <div className="chatbot-footer">
                <button
                    type="button"
                    className="chatbot-footer__reset"
                    onClick={resetChat}
                    aria-label="Започни нов разговор"
                >
                    ↺ Нов разговор
                </button>

                {isLoggedIn && (
                    <Link to="/chatbot/results" className="chatbot-footer__results-link">
                        Виж резултатите →
                    </Link>
                )}
            </div>
        </div>
    );
}

export default Chatbot;

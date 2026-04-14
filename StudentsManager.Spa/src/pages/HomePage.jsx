import React, { useEffect, useRef } from 'react';
import robotImage from '../assets/home/robot.png';
import './HomePage.css';

function HomePage() {
    const canvasRef = useRef(null);

    // Matrix Rain Effect
    useEffect(() => {
        const canvas = canvasRef.current;
        const ctx = canvas.getContext('2d');
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;

        const characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789<>/{}[];:+-*";
        const fontSize = 16;
        const columns = canvas.width / fontSize;
        const drops = Array(Math.floor(columns)).fill(1);

        const draw = () => {
            ctx.fillStyle = "rgba(0, 0, 0, 0.05)";
            ctx.fillRect(0, 0, canvas.width, canvas.height);
            ctx.fillStyle = "#0F0"; // Matrix Green
            ctx.font = fontSize + "px monospace";

            for (let i = 0; i < drops.length; i++) {
                const text = characters.charAt(Math.floor(Math.random() * characters.length));
                ctx.fillText(text, i * fontSize, drops[i] * fontSize);
                if (drops[i] * fontSize > canvas.height && Math.random() > 0.975) {
                    drops[i] = 0;
                }
                drops[i]++;
            }
        };

        const interval = setInterval(draw, 33);
        return () => clearInterval(interval);
    }, []);

    return (
        <div className="hp-container">
            {/* Background Matrix Effect */}
            <canvas ref={canvasRef} className="matrix-canvas"></canvas>

            {/* 1. Hero Section */}
            <section className="hp-hero">
                <div className="hero-content">
                    <h1 className="hero-title">Welcome <br/><span>Heidelberg Materials</span></h1>
                    <p className="hero-subtitle">Elevating engineering through innovation.</p>
                </div>
                <div className="robot-container">
                    <img src={robotImage} alt="Robot Guide" className="robot-anim" />
                </div>
            </section>

            {/* 2. Personalized Dashboard Preview */}
            <section className="hp-section dashboard-preview">
                <h2 className="section-title">Your learning, your pace</h2>
                <div className="stats-grid">
                    <div className="stat-card">
                        <span>Completed Tasks</span>
                        <div className="progress-bar"><div className="progress-fill" style={{width: '75%'}}></div></div>
                        <span className="stat-val">75%</span>
                    </div>
                    <div className="stat-card">
                        <span>Accuracy</span>
                        <div className="progress-bar"><div className="progress-fill green" style={{width: '92%'}}></div></div>
                        <span className="stat-val">92%</span>
                    </div>
                    <div className="stat-card">
                        <span>Weekly Activity</span>
                        <div className="activity-dots">
                            {[...Array(7)].map((_, i) => <div key={i} className={`dot ${i < 5 ? 'active' : ''}`}></div>)}
                        </div>
                        <span className="stat-val">High</span>
                    </div>
                </div>
            </section>

            {/* 3. Forum Section */}
            <section className="hp-section forum-preview">
                <div className="glass-card">
                    <h2>Student Community</h2>
                    <p>Discuss problems, share insights, and grow together with your peers.</p>
                    <button className="hp-btn">Go to Forum</button>
                </div>
            </section>

            {/* 4. Daily Challenge */}
            <section className="hp-section daily-challenge">
                <div className="challenge-box">
                    <div className="challenge-header">
                        <span className="tag">Daily Challenge</span>
                        <span className="timer">Next in: 14:22:05</span>
                    </div>
                    <h3>Solve today's problem</h3>
                    <code className="challenge-snippet">
                        function solve(n) {'{'} return n * (n + 1) / 2; {'}'}
                    </code>
                    <button className="hp-btn outline">View Task</button>
                </div>
            </section>

            {/* 5. Achievements & Progress */}
            <section className="hp-section timeline-preview">
                <h2 className="section-title">Recent Achievements</h2>
                <div className="timeline">
                    <div className="timeline-item"><span>Ivan G.</span> unlocked "Fast Coder" badge</div>
                    <div className="timeline-item"><span>Maria K.</span> completed "React Basics"</div>
                </div>
                <button className="hp-link-btn" onClick={() => window.location.href='/timeline'}>
                    View Full Timeline →
                </button>
            </section>

            {/* 6. Call to Action (Final Hit) */}
            <section className="hp-cta">
                <h2>Start your journey today</h2>
                <button className="cta-main-btn">Join Now / Get Started</button>
            </section>
        </div>
    );
}

export default HomePage;
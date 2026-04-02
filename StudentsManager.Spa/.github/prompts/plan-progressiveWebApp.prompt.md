# Plan: Transform SPA into Progressive Web App

**TL;DR:** Add `vite-plugin-pwa` to the existing Vite+React SPA to meet PWA installability requirements (web manifest, service worker, icons). Minimal offline strategy — precache the app shell so the browser treats it as installable; no API caching or custom install prompt. Generate required icon assets from the existing `logo.svg`.

---

### Phase 1 — Icon Generation (no code dependencies)

1. **Generate PWA icon assets from `src/assets/icons/logo.svg`**
   - Install `@vite-pwa/assets-generator` as a dev dependency
   - Produce: `pwa-64x64.png`, `pwa-192x192.png`, `pwa-512x512.png`, `apple-touch-icon-180x180.png`, `maskable-icon-512x512.png` → all into `public/`
   - Add a one-time script in `package.json`: `"generate-pwa-assets": "pwa-assets-generator --preset minimal-2023 src/assets/icons/logo.svg"`

### Phase 2 — Plugin & Manifest Setup (*depends on Phase 1*)

2. **Install `vite-plugin-pwa` as a dev dependency**
   - `npm install -D vite-plugin-pwa`
   - Compatibility note: rolldown-vite@7.2.5 — upstream fixes merged (PRs #843, #877). Pin to v1.2.0 if issues arise.

3. **Configure `VitePWA` plugin in `vite.config.js`**
   - `registerType: 'autoUpdate'` — silent SW updates, no reload prompts
   - `manifest`: name "Students Manager", `short_name` "StudMan", `theme_color`/`background_color` matching existing CSS (`#1a1a2e`), `display: "standalone"`, icons referencing the generated PNGs (including `purpose: "maskable"`)
   - `workbox.globPatterns`: `['**/*.{js,css,html,svg,png,woff2,woff,json}']` — precache app shell + fonts + static data
   - No `runtimeCaching` — minimal strategy

4. **Update `index.html` `<head>` with PWA meta tags**
   - Add `<meta name="theme-color" content="#1a1a2e" />`
   - Add `<meta name="description" content="Students Manager SPA" />`
   - Add `<link rel="apple-touch-icon" href="/apple-touch-icon-180x180.png" />`
   - Replace favicon from `vite.svg` → `pwa-64x64.png`
   - Manifest `<link>` is auto-injected by the plugin — no manual link needed

### Phase 3 — Nginx Adjustments (*parallel with Phase 2*)

5. **Update `nginx/default.conf` for service worker serving**
   - Add a location block so `sw.js` is never aggressively cached:
     ```
     location = /sw.js {
       add_header Cache-Control "no-cache";
       try_files $uri =404;
     }
     ```
   - Existing `/assets/` immutable caching is already correct — no change needed

### Phase 4 — Verification (*depends on Phase 2 & 3*)

6. **Build and verify PWA compliance**
   - `npm run build` → confirm `dist/` contains `sw.js`, `manifest.webmanifest`, icon PNGs
   - `npm run preview` → Chrome DevTools Application tab: manifest shows icons/metadata, SW is registered
   - Lighthouse PWA audit passes installability checks
   - Browser install icon appears in address bar
   - Docker build completes and `sw.js` served with correct headers

---

## Relevant Files

- `vite.config.js` — add `VitePWA` plugin configuration
- `index.html` — PWA meta tags, updated favicon
- `nginx/default.conf` — service worker cache header
- `package.json` — new dev dependencies + generate script
- `public/` — 5 new generated PNG icon files

## Verification

1. `npm run build` succeeds and `dist/` contains: `sw.js`, `manifest.webmanifest`, generated icon PNGs, `registerSW.js`
2. `npm run preview` → Chrome DevTools → Application tab → Manifest shows all icons, correct name/colors/display
3. `npm run preview` → Chrome DevTools → Application tab → Service Workers shows active SW
4. `npm run preview` → Lighthouse → PWA audit passes installability checks
5. Browser address bar shows install icon (Chrome desktop) or "Add to Home Screen" prompt is available
6. `npm run dev` works without errors (dev mode SW integration)
7. Docker build (`docker build .`) completes successfully — `sw.js` served with no-cache header

## Decisions

- **Minimal offline strategy chosen**: SW precaches the app shell for installability but does not cache API responses. Users offline will see cached HTML/CSS/JS but API calls will fail normally.
- **No custom install prompt**: Relying on browser-native install UX.
- **`registerType: 'autoUpdate'`**: SW updates silently in background — no "new version available" toast. Simplest UX for minimal PWA.
- **`@vite-pwa/assets-generator` over manual conversion**: Produces correctly sized/formatted icons including maskable variants with proper padding.
- **rolldown-vite compatibility**: Upstream fixes merged (PRs #843, #877, #882). If build breaks, fallback is pinning `vite-plugin-pwa@1.2.0`.
- **Excluded from scope**: Push notifications, background sync, offline API caching, custom install banner, offline fallback page.

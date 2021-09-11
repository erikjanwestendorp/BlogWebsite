import './assets/scss/style.scss';
import { createApp } from 'vue';


const app = createApp({}); 


// Global components
const importComponents = (r: __WebpackModuleApi.RequireContext) => {
    r.keys().forEach((key: string) => {
        const name = key.match(/\/([^/]*)\./);
        if (name && name[1] && !name[1].startsWith('_')) {
            app.component(name[1], r(key).default);
        }
    });
};
importComponents(require.context('./components/', true, /\.vue$/));


// Wait for DOM to load
document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('body script').forEach((script: Element) => {
        if (script.parentNode) script.parentNode.removeChild(script);
    });
    const head = document.querySelector('head');
    document.querySelectorAll('body style').forEach((style: Element) => {
        if (style.parentNode) style.parentNode.removeChild(style);
        if (head) head.appendChild(style);
    });
    // Mount
    app.mount('body');
});
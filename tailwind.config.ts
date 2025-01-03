import type { Config } from "tailwindcss";

export default {
  content: [
    "./Controllers/**/*.{cshtml,js,ts}",
    "./Models/**/*.{cshtml,js,ts}",
    "./Pages/**/*.{cshtml,js,ts}",
  ],
  theme: {
    extend: {},
  },
  plugins: [],
} satisfies Config;
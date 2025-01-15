import { defineConfig } from "cypress";

export default defineConfig({
  e2e: {
    setupNodeEvents(on, config) {},
    env: {
      home_url: "https://127.0.0.1:4200/",
      order_url: "https://127.0.0.1:4200/order",
      menu_url: "https://127.0.0.1:4200/menu",
      payment_url: "https://127.0.0.1:4200/payment",
      cart_url: "https://127.0.0.1:4200/cart"
    },
  },

  component: {
    devServer: {
      framework: "angular",
      bundler: "webpack",
    },
    specPattern: "**/*.cy.ts",
  },
});

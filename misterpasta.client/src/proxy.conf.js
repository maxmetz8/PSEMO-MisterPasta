const PROXY_CONFIG = [
  {
    context: ["/weatherforecast"],
    target: "http://localhost:5186",
    secure: false,
    changeOrigin: true,
    logLevel: "debug"
  }
];

module.exports = PROXY_CONFIG;

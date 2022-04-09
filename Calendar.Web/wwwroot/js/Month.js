const currentMonth = new Date().getMonth() + 1;
console.log(currentMonth); // 👉️ 10

// 👇️ Get Name of Current Month
const nameOfMonth = new Date().toLocaleString(
    'default', { month: 'long' }
);
console.log(nameOfMonth); // 👉️ October

// 👇️ Get Localized Names of Current Month
const nameOfMonthUS = new Date().toLocaleString(
    'en-US', { month: 'long' }
);
console.log(nameOfMonthUS); // 👉️ October

const nameOfMonthDE = new Date().toLocaleString(
    'de-DE', { month: 'long' }
);
console.log(nameOfMonthDE); // 👉️ Okto 
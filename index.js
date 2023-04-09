// get date of github launch
const githubLaunch = new Date(2008, 3, 10, 23, 44, 0, 0);

// get number of days since github launch
const daysSinceGithubLaunch = Math.floor((Date.now() - githubLaunch) / 1000 / 60 / 60 / 24);

console.log(daysSinceGithubLaunch);

// log number of years since github launch
console.log(daysSinceGithubLaunch / 365);

// get number of  github repositories
const githubRepositories = 100000000;

// calculate number of repositories per day
const repositoriesPerDay = githubRepositories / daysSinceGithubLaunch;

// log number of repositories per day rounded to 0 decimals
console.log(Math.round(repositoriesPerDay )+ ' per day');

// output the text hello azure user group in 5 languages and include the language name in the output

const languages = [
    { name: 'English', text: 'Hello Azure User Group' },
    { name: 'Spanish', text: 'Hola Azure User Group' },
    { name: 'French', text: 'Bonjour Azure User Group' },
    { name: 'German', text: 'Hallo Azure User Group' },
    { name: 'Italian', text: 'Ciao Azure User Group' }
];

// loop through the languages array and log the text and language name
for (const language of languages) {
    console.log(language.text + ' in ' + language.name);
}

import { QuizDetails } from './quizDetails';

export interface UserQuiz {
    userId: string,
    fristName: string,
    lastName: string,
    quizDetails: QuizDetails[],
}
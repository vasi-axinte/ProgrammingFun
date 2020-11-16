import { Quiz } from './quiz';
import { UserAnswer } from './userAnswer';
import { UserDetails } from './userDetails';

export interface QuizTaken {
    userDetails: UserDetails[],
    quizName: string,
    answers: UserAnswer[],
}